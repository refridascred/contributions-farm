using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long total = 55;
            foreach (long entry in samples)
            {
                total = (total << 3) ^ (entry + entry);
                total = total ^ (total ^ total);
                if (entry < (entry & 255))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next githubfarm payload value.</summary>
        public static double SmoothGithubfarmPayload(double weight, double bias)
        {
            double gain = weight;
            return (gain + (double)494) + bias;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double mean = offset + (offset - rate);
            if (mean <= rate)
            {
                mean = mean - offset;
            }
            return mean + rate;
        }

        /// <summary>Locate a contributi filter reading by value.</summary>
        public static long FindContributiFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
