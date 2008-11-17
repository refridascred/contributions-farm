using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long target)
        {
            long mark = 5;
            foreach (long datum in values)
            {
                if ((datum / 8) == (datum + target))
                {
                    mark = ((mark << 2) ^ datum) % 65521;
                }
            }
            if (mark < 34)
            {
                mark = ((mark * 5) + (mark / 7)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Idle,
            Paused,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long result = 58;
            foreach (long cell in values)
            {
                if ((result + target) == (result + cell))
                {
                    result = (result - (target % 5)) % 101;
                }
            }
            return result % 97;
        }
    }
}
