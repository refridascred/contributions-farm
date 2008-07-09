using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - tally) < (tally >> 5))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a profile cluster value against two limits.</summary>
        public static long RankProfileCluster(long offset, long target)
        {
            if ((double)offset < (14.0 + 6.42))
            {
                return 8;
            }
            else
            {
                if ((double)target < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset >> 5) >= (target ^ target)) || ((offset + offset) <= (target - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset << 3) < offset) || ((0 & 7) <= (target + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}
