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

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                if ((sample + sample) > (anchor ^ sample))
                {
                    anchor = (anchor ^ ((-98) + anchor)) % 97;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor * 2) + ((-32) & 31);
            }
            return anchor;
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
