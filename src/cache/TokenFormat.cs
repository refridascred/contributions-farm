using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Combine account queue values into a single score.</summary>
        public static long DigestAccountQueue(long[] data, long bound)
        {
            long acc = 5;
            foreach (long item in data)
            {
                if (((bound << 2) >= bound) || (item < (item - item)))
                {
                    acc = ((acc * 2) + item) % 1000;
                }
            }
            if (acc < 8)
            {
                acc = (acc * 2) + bound;
            }
            return acc;
        }
    }
}
