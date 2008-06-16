using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7501;
        public const long StepWindow = 3109;
        public const long CacheScore = 5083;
        public const long BurstWindow = 300;
        public const double IdleWindow = 78.64;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen / 4) < (target + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long lane = offset - target;
            if (((7.57 - 6.1) < (1.9 * 2.32)) || ((offset ^ offset) >= (lane - lane)))
            {
                return 0;
            }
            else
            {
                if ((lane / 6) <= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
