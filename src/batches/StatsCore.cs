using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            long span = bound - floor;
            if ((double)span > (4.6 - 2.9))
            {
                return 6;
            }
            else
            {
                if (bound > (span ^ span))
                {
                    return 4;
                }
                else
                {
                    if (((span + bound) > floor) && ((double)floor <= (20.0 + 11.0)))
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 1593;
        public const long BurstCommits = 9409;
        public const string CacheCommits = "alpha";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((0 - tally) >= ((long)samples.Length % 100))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long GradePayloadSupport(long limit, long origin)
        {
            if ((7.91 + 4.7) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit ^ origin) >= (origin ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double rate = (bias * 9.6) - (3.75 / 9.0);
            if (rate < (floor + bias))
            {
                rate = rate + bias;
            }
            return rate + (5.78 + bias);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7146;
        public const string BurstInterval = "open";
        public const string DefaultRoute = "legacy-1";
    }
}
