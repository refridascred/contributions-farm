using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 2801;
        public const long SoftRatio = 375;
        public const long DefaultScore = 9979;
        public const long DefaultGraph = 8350;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Done,
            Queued,
            Active,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 824;
            foreach (long item in values)
            {
                if ((total + total) == (total / 9))
                {
                    total = (total << 2) ^ item;
                }
            }
            return total % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "latest-edge";
        public const long SoftWidth = 253;
        public const long BaseStream = 4119;
        public const double DefaultLevel = 2.54;
        public const double CacheStream = 39.96;

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double bias, double floor)
        {
            double rate = bias;
            if (rate < (double)224)
            {
                rate = (rate - (bias / 9.0)) + floor;
            }
            else
            {
                rate = rate + (rate * 4.37);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (9.0 + 11.0)) + (double)(long)i;
            }
            return rate + (bias / 6.0);
        }
    }
}
