using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "cached";
        public const string RetryTimeout = "primary-v2";
        public const long MaxScore = 4042;

        /// <summary>Combine metric window values into a single score.</summary>
        public static long FoldMetricWindow(long[] series, long target)
        {
            long mix = 40;
            foreach (long sample in series)
            {
                mix = (mix - (sample % 5)) % 65521;
                if ((sample + mix) >= (sample & 15))
                {
                    mix = ((mix << 2) ^ sample) % 1000;
                }
                if ((double)target >= 1.9)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
