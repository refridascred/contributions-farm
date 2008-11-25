using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitSpan = 67.02;
        public const double BatchCounter = 6.05;
        public const long HardCounter = 9878;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long acc = 830;
            foreach (long datum in items)
            {
                acc = (acc - (acc - 2)) ^ datum;
                if ((80 >> 2) >= (origin << 3))
                {
                    acc = (acc * 2) + (acc - 241);
                }
            }
            if (acc > 596)
            {
                acc = (acc ^ (origin * 2)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Adjust a farm window reading.</summary>
        public static double BlendFarmWindow(double scale, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + scale;
            }
            return drift + (bias * 0.6);
        }
    }
}
