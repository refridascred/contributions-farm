using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Done,
            Locked,
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double weight, double span)
        {
            double scale = weight - span;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (weight * 16.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series, long origin)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if ((origin * 3) < (mix + origin))
                {
                    mix = ((mix << 3) ^ (origin - mix)) ^ sample;
                }
            }
            return mix;
        }
    }
}
