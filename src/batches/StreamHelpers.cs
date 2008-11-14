using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long carry = 207;
            foreach (long sample in readings)
            {
                if ((offset & 7) > sample)
                {
                    carry = carry + (offset >> 5);
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 6.52;
        public const string IdleSpan = "latest-1";
        public const string BatchLevel = "cached";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm payload readings against a rule.</summary>
        public static long AuditFarmPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (6.1 * 13.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long seed)
        {
            long bound2 = bound + seed;
            if ((bound + bound) != (bound - bound))
            {
                return 7;
            }
            else
            {
                if (((seed / 5) == (bound - seed)) && ((double)bound2 >= (17.0 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - bound2) > (bound2 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (9.49 < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
