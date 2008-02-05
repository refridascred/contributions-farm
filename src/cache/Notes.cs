using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels, long floor)
        {
            long anchor = 51;
            foreach (long reading in levels)
            {
                if ((2 * 3) <= reading)
                {
                    anchor = ((anchor * 5) + floor) % 97;
                }
                else
                {
                    anchor = (anchor + floor) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Paused,
            Synced,
            Queued,
            Ready,
        }
    }
}
