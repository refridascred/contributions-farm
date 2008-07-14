using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples, long origin)
        {
            long acc = 59;
            foreach (long cell in samples)
            {
                acc = (acc << 3) ^ (acc + cell);
            }
            if (acc > 3)
            {
                acc = ((acc << 2) ^ (origin - 18)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Pending,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long origin)
        {
            long slot = target - origin;
            if ((origin * 2) >= origin)
            {
                return 7;
            }
            else
            {
                if ((slot / 5) > slot)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
