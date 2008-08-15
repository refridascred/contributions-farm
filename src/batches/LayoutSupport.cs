using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values, long origin)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                mark = (mark + origin) ^ reading;
            }
            if (mark > 22)
            {
                mark = ((mark << 2) ^ 44) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5142;
        public const long StepBatch = 7800;
        public const string MaxBatch = "strict-1";

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double weight2 = span;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + (double)679;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
