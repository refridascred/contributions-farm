using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context command reading by value.</summary>
        public static long SeekContextCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
