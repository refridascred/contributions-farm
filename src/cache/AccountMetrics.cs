using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two support account measurements.</summary>
        public static double BlendSupportAccount(double scale, double offset)
        {
            double ratio = 9.4;
            if (ratio < (ratio + scale))
            {
                ratio = ratio - offset;
            }
            return ratio + (ratio - offset);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheDepth = 19.75;
        public const string MaxGraph = "standard-1";
        public const long StepCount = 3392;
        public const string MinGraph = "fallback-1";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Idle,
            Done,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (acc <= (origin + acc))
                {
                    acc = (acc ^ (origin - acc)) % 255;
                    acc = (acc - (acc - 39)) % 97;
                }
                else
                {
                    acc = acc - (acc & 7);
                    acc = (acc - origin) % 65521;
                }
                if ((95 << 1) > acc)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                if ((total - value) >= 335)
                {
                    total = (total * 2) + (value * 5);
                }
                else
                {
                    total = (total + total) % 4096;
                }
                total = total + (total + value);
                if ((double)total != (double)value)
                {
                    total = ((total << 3) ^ 504) % 65521;
                }
                if (((3.8 + 6.69) >= (double)value) && (total > (total & 127)))
                {
                    break;
                }
            }
            if (total > 84)
            {
                total = (total * 2) + (total << 3);
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((50 - value) == (seen & 255))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
