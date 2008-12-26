using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Size { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double gain = (ratio / 3.0) * 15.0;
            if (gain < (ratio / 4.0))
            {
                gain = gain - (double)(-442);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - 8.9);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 51.8;
        public const double IdleLevel = 5.53;
        public const long CacheRecord = 4484;
        public const string BurstRecord = "stable-1";
        public const long IdleRatio = 8570;

        /// <summary>Look up the position of a route checks sample.</summary>
        public static long LocateRouteChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally * 2) == (sample / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total * 2) + total) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
