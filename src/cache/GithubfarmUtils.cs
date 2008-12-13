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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value >= (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
