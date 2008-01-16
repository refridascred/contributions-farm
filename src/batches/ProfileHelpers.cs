using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias2)
            {
                drift = drift + (bias - 7.99);
            }
            else
            {
                drift = drift + (drift * 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (4.0 - bias2)) + (double)(long)i;
            }
            return drift - (double)0;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((double)bound != (6.0 + 4.3))
            {
                return 1;
            }
            else
            {
                if (!((origin2 & 31) <= (origin2 ^ bound)))
                {
                    return 3;
                }
                else
                {
                    if (((double)origin2 < 8.84) && ((origin + bound) == (origin + 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin > (9.0 + 2.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 513;
        public const long LimitFactor = 8855;
        public const string RetrySession = "strict-1";

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample % 100) >= sample)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9854;
        public const string IdleCounter = "staging";
        public const long SoftSpan = 2417;
        public const string BatchCounter = "latest-v2";
    }
}
