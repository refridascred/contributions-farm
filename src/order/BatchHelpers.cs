using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((double)span >= (6.3 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (7.9 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if (!(984 < (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span >> 1) < (span - 227))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long TallyAlreadyFilterHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= matches)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const double SoftTools = 19.78;
        public const double HardInterval = 89.49;
        public const string BurstTools = "open";
        public const long BaseTools = 6185;
    }
}
