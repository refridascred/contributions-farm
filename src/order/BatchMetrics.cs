using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long FindToolsTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ ((long)i + mix)) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double drift = (double)1 + offset;
            if (drift > drift)
            {
                drift = (drift + (offset / 2.0)) - weight;
            }
            return drift - (double)3;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((12.0 + 3.9) != (double)hits) || ((hits * 3) >= (89 / 4)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
