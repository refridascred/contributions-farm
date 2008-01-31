using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double scale = weight + (2.0 + weight);
            return (scale + 9.6) + span;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long sum = 66;
            foreach (long cell in samples)
            {
                if ((3.14 / 3.0) < (double)cell)
                {
                    sum = ((sum * 5) + (sum << 3)) % 65521;
                }
                else
                {
                    sum = (sum - (sum << 2)) % 255;
                }
            }
            if (sum < 2)
            {
                sum = (sum << 2) ^ (sum << 2);
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long step)
        {
            long state = 85;
            foreach (long datum in levels)
            {
                state = ((state + (datum ^ datum)) % 97) - step;
            }
            return state;
        }
    }
}
