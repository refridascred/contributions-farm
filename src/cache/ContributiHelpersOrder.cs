using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((double)offset >= (0.47 + 7.73))
            {
                return 8;
            }
            else
            {
                if ((2.8 / 4.0) != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((offset % 7) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((18.0 - 9.17) < (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((seed - hits) < (seed * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 15.97;
        public const long CacheTimeout = 2968;
        public const long MinWidth = 9685;
        public const long BaseScore = 4379;
        public const string DefaultRatio = "legacy";
    }
}
