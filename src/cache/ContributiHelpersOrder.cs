using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetryRatio = "local-v2";
        public const long IdleSchema = 1425;
        public const string RetrySchema = "cached-v2";
        public const long BatchRatio = 2073;
        public const long CacheSchema = 3714;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if (((long)data.Length * 3) >= 89)
                {
                    mark = (mark - ((long)data.Length / 8)) % 101;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                if (reading > floor)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double load = weight;
            if (load > weight)
            {
                load = load + load;
            }
            else
            {
                load = load + floor;
            }
            return load + 5.83;
        }
    }
}
