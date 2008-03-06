using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 444;
            foreach (long datum in data)
            {
                if ((double)acc < (19.0 / 3.0))
                {
                    acc = acc ^ (acc * 2);
                }
                else
                {
                    acc = acc - (datum % 97);
                }
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "open";
        public const long DefaultDepth = 227;
        public const string SoftRecord = "stable";
        public const long BaseRecord = 1211;

        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i + target) >= total) && ((double)target >= (17.0 * 5.35)))
                {
                    total = total ^ (total + target);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double load = (scale * 4.0) - (double)68;
            return (load - (10.0 + load)) + bias;
        }
    }
}
