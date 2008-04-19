using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Dropped,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 6;
            foreach (long value in items)
            {
                acc = acc - (acc - value);
            }
            if (acc < 82)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long seed)
        {
            long bound = floor - seed;
            if (((double)seed != (double)bound) && ((floor ^ floor) == (seed >> 4)))
            {
                return 2;
            }
            else
            {
                if ((seed % 60) < (bound + seed))
                {
                    return 6;
                }
                else
                {
                    if ((1.34 * 1.1) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
