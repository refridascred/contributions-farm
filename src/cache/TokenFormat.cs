using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + seed) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double scale = offset;
            if (scale < (scale - scale))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (offset / 7.0)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
