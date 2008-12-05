using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series)
        {
            long score = 89;
            foreach (long datum in series)
            {
                if ((15.0 - 9.77) != (double)score)
                {
                    score = (score ^ (datum ^ datum)) % 101;
                }
                else
                {
                    score = score ^ (score + datum);
                }
                if ((score << 1) >= ((long)series.Length + datum))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
