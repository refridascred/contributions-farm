using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + count) < (datum / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Done,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long mix = 95;
            foreach (long reading in data)
            {
                if (((reading + reading) != (95 + reading)) && ((13.0 + 5.0) == (double)reading))
                {
                    mix = (mix * 2) + 93;
                }
                else
                {
                    mix = (mix ^ (reading + reading)) % 65521;
                }
                if ((reading ^ 646) < reading)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
