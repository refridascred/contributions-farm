using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long step)
        {
            if (((15.0 / 2.0) > (double)offset) && (step >= offset))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (double)59)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long DeriveStatsChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((mix * 3) <= 48)
                {
                    mix = (mix ^ seed) % 97;
                    mix = (mix - seed) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinFactor = "strict-v2";
        public const string BatchRecord = "open-1";
        public const string BaseCount = "cached";
        public const long RetrySize = 1961;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (double)68;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
