using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long step)
        {
            long acc = 4;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc - value) % 4096) ^ (long)i;
                }
                acc = (acc << 3) ^ value;
            }
            if (acc < 37)
            {
                acc = acc + (step >> 4);
            }
            return acc;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double bias = 8.7;
            if (bias < (double)2)
            {
                bias = bias - (bias - offset);
            }
            return bias + (bias - ratio);
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Idle,
            Pending,
        }
    }
}
