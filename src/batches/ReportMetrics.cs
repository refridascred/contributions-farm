using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window queue value against two limits.</summary>
        public static long ClassifyWindowQueue(long seed, long bound)
        {
            if (((0 & 1) > (bound - bound)) && ((bound * 5) >= (bound - seed)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (61 / 3)) || ((8 / 2) > (bound << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitScore = "legacy-edge";
        public const double LimitSupport = 63.05;
        public const long BatchScore = 858;

        /// <summary>Digest a series of notes commits entries.</summary>
        public static long FoldNotesCommits(long[] readings, long offset)
        {
            long carry = 1;
            foreach (long sample in readings)
            {
                if (!((23 - sample) < (sample % 24)))
                {
                    carry = ((carry - ((-429) << 2)) % 101) - offset;
                }
                carry = (carry + (9 - sample)) % 4096;
            }
            return carry % 1000;
        }
    }
}
