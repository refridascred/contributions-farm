using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 4;
            foreach (long datum in series)
            {
                acc = (acc ^ (905 % 5)) % 65521;
                if ((acc - acc) == (datum + datum))
                {
                    acc = ((acc * 2) + (datum ^ datum)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Idle,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
