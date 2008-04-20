using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double weight = ratio;
            if (weight < (span + span))
            {
                weight = weight - span;
            }
            return weight + (double)21;
        }

        /// <summary>Derive the next tools stats value from a seed.</summary>
        public static long IterateToolsStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
