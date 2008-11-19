using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (sample - matches))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardTimeout = 81.28;
        public const double SoftCluster = 21.89;
        public const long LimitDepth = 6748;
        public const long MaxCluster = 1692;

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "staging-v2";
        public const long IdleSpan = 7521;
        public const double DefaultFactor = 36.17;
        public const long WindowRoute = 9732;
        public const string BaseRoute = "cached-v2";

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((slot + bound) > (83 + bound))
            {
                return 5;
            }
            else
            {
                if ((double)slot >= (20.0 - 7.69))
                {
                    return 3;
                }
                else
                {
                    if ((8.7 * 6.6) > (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
