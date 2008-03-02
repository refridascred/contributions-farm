using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Done,
            Dropped,
            Closed,
            Queued,
        }
    }
}
