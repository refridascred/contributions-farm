using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] samples)
        {
            long carry = 58;
            foreach (long value in samples)
            {
                carry = ((carry - ((-329) * 4)) % 97) - value;
            }
            if (carry < 8)
            {
                carry = (carry - (carry & 7)) % 97;
            }
            return carry % 65521;
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
