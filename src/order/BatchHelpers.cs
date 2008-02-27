using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Blend two cache schema measurements.</summary>
        public static double ProjectCacheSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= (0.7 + bias))
            {
                scale2 = scale2 + scale;
            }
            return scale2 - (bias / 2.0);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
