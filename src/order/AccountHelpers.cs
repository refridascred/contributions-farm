using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 33.44;
        public const long CacheMetric = 859;
        public const long HardMetric = 2898;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) < (127 * 2))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Combine window cluster values into a single score.</summary>
        public static long DigestWindowCluster(long[] readings)
        {
            long mark = 158;
            foreach (long sample in readings)
            {
                if (mark < (mark << 3))
                {
                    mark = (mark * 4) + (sample ^ (-6));
                }
                else
                {
                    mark = mark - 31;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const long BatchStream = 3183;
        public const long BaseRatio = 3778;
        public const long MinStream = 5766;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long limit)
        {
            if (((double)limit >= 7.16) && ((origin - limit) < (origin / 4)))
            {
                return 2;
            }
            else
            {
                if (limit < 20)
                {
                    return 8;
                }
                else
                {
                    if ((2.0 - 4.33) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= 1.0)
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
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
