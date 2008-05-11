using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((205 < step) || ((double)(long)i >= (double)step))
                {
                    acc = ((acc << 2) ^ 70) % 97;
                }
                if ((double)41 < (double)step)
                {
                    long bound = 32;
                    acc = ((acc * 4) + (bound % 97)) % 255;
                }
                else
                {
                    acc = (acc - (acc + (long)i)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long bound)
        {
            long mix = 54;
            foreach (long cell in levels)
            {
                if (938 < cell)
                {
                    mix = (((mix << 2) ^ (mix * 5)) % 101) - bound;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a account stream reading.</summary>
        public static double ProjectAccountStream(double rate, double bias)
        {
            double scale = (double)(97 & 127);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(long)i) - rate;
            }
            return scale - bias;
        }
    }
}
