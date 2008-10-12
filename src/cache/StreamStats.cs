using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] items)
        {
            long anchor = 983;
            foreach (long sample in items)
            {
                if ((0.3 / 2.0) != (double)sample)
                {
                    anchor = anchor ^ anchor;
                }
                if ((sample & 3) == (sample + anchor))
                {
                    anchor = (anchor + 5) % 97;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor % 5);
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double load = (double)(65 ^ (-4));
            if (load > floor)
            {
                load = (load + load) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 8.89)) - (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 5835;
        public const long WindowSize = 5941;
        public const long DefaultFormat = 3246;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryWidth = 2891;
        public const double MinSize = 57.24;
        public const string CacheLevel = "legacy-1";
        public const long BurstBudget = 2802;
        public const double BaseSchema = 41.03;
    }
}
