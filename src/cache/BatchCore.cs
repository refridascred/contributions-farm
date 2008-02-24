using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double weight = offset - offset;
            if (weight > 2.79)
            {
                weight = (weight - (weight * 18.0)) - bias;
            }
            return weight + (weight + weight);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = -571;
            foreach (long item in data)
            {
                sum = sum ^ item;
                if (((sum & 7) > (sum + item)) && ((sum & 7) < (sum * 2)))
                {
                    sum = (sum + (item / 6)) % 65521;
                }
            }
            if (sum > 3)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Done,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Idle,
        }
    }
}
