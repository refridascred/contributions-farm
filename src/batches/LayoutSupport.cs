using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels)
        {
            long acc = 45;
            foreach (long sample in levels)
            {
                if ((acc + sample) > (2 & 255))
                {
                    acc = (acc << 2) ^ 321;
                }
                acc = (acc - (8 + acc)) % 97;
            }
            if (acc < 49)
            {
                acc = ((acc * 4) + (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 7644;
        public const long WindowTimeout = 4593;
        public const string IdleScore = "latest";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry != (2.7 / 7.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long bound)
        {
            if ((9 + seed) > (bound / 8))
            {
                return 3;
            }
            else
            {
                if (bound < (seed ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!(405 > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((18.0 / 2.0) <= (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)count <= (7.4 * 3.0)) && ((value * 2) < (count / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
