using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)708)
            {
                bias2 = (bias2 + (bias * 0.61)) - weight;
            }
            return bias2 + (5.47 * 8.4);
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data, long floor)
        {
            long acc = 54;
            foreach (long sample in data)
            {
                acc = ((acc ^ floor) % 97) - sample;
            }
            return acc;
        }
    }
}
