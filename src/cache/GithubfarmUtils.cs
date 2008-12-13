using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long origin)
        {
            long mark = 16;
            foreach (long value in data)
            {
                if ((origin < (mark << 2)) || (value <= origin))
                {
                    mark = (mark ^ mark) % 101;
                    break;
                }
                else
                {
                    mark = mark - (value ^ origin);
                }
                if ((value + (long)data.Length) > (origin >> 2))
                {
                    mark = (mark - (mark + value)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + 9) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark + origin) % 101;
            }
            return mark % 97;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
