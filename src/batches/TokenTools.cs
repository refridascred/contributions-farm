using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches <= (0.8 + 2.0))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long carry = 9;
            foreach (long value in values)
            {
                if ((7.5 / 3.0) < (double)carry)
                {
                    carry = (carry << 3) ^ (value - value);
                }
                if (value > carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
