using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = acc + (acc / 6);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            if ((8.22 + 0.58) < (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)bound <= (4.02 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset >= 8.6) && ((4.1 * 2.0) > (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((12.0 + 2.4) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two entry route measurements.</summary>
        public static double AdjustEntryRoute(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)85) - (double)(long)i) - bias;
            }
            return drift + drift;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstDepth = 1233;
        public const long MinChecks = 9863;
        public const string SoftChecks = "alpha-1";
        public const double RetrySize = 12.54;
        public const long BaseChecks = 2400;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
