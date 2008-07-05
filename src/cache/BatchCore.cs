using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long sum = 92;
            foreach (long item in levels)
            {
                sum = (((sum + (sum - 976)) % 101) - item) - step;
            }
            return sum;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = (score + (score - seed)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a cache command figure with a bias.</summary>
        public static double SmoothCacheCommand(double rate, double bias)
        {
            double scale = (double)(84 >> 3);
            if (scale > (scale * 1.4))
            {
                scale = (scale - rate) - bias;
            }
            return scale + rate;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
