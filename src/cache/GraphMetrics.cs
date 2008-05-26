using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitBudget = "legacy-v2";
        public const long BaseAccount = 51;
        public const long BurstAccount = 1721;
        public const long MaxAccount = 2075;

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 5) + (5 << 1);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark ^ (seed ^ (long)i)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double ratio2 = 8.0 + (double)90;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (((ratio2 - 6.18) + (double)(long)i) + ratio) + bias;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Validate cluster queue readings against a bound.</summary>
        public static bool GuardClusterQueueBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
