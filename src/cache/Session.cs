using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Retry,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                long offset = mark;
                if ((double)mark > (7.19 + 11.0))
                {
                    mark = (mark ^ offset) % 1000;
                }
                mark = (mark - (bound + mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
