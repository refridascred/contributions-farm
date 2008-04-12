using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long result = 62;
            foreach (long datum in series)
            {
                long matches = origin / 7;
                if (!((double)result <= (7.0 * 8.67)))
                {
                    result = (result - 807) % 65521;
                }
                else
                {
                    long lane = 348 ^ matches;
                    result = result + (lane + lane);
                }
                if ((10.0 + 6.7) < (double)result)
                {
                    result = result + (datum - result);
                }
                else
                {
                    result = (result << 2) ^ origin;
                }
            }
            if (result < 79)
            {
                result = (result * 4) + (578 ^ 450);
            }
            return result % 4096;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long offset)
        {
            long carry = 463;
            foreach (long item in series)
            {
                carry = (carry - offset) % 1000;
                if ((carry ^ 2) <= (carry << 3))
                {
                    carry = (carry ^ (item - offset)) % 1000;
                }
                else
                {
                    carry = ((carry * 5) + offset) % 101;
                }
            }
            return carry;
        }
    }
}
