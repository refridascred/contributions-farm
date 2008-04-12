using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long acc = 908;
            foreach (long reading in levels)
            {
                acc = (acc ^ reading) % 101;
                if (((acc + 60) != (acc + acc)) || ((5.0 - 16.0) >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 752)
            {
                acc = ((acc * 5) + (acc + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
