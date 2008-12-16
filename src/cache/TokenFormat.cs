using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Dropped,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile buffer samples.</summary>
        public static long ScoreProfileBuffer(long[] values, long target)
        {
            long acc = 511;
            foreach (long cell in values)
            {
                if (acc <= (cell << 2))
                {
                    acc = (acc - (acc + cell)) - target;
                }
            }
            return acc;
        }
    }
}
