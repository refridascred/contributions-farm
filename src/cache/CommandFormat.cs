using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - datum)) % 4096;
                if (!((7 & 255) <= (datum / 8)))
                {
                    sum = ((sum << 3) ^ (414 + sum)) % 101;
                }
                else
                {
                    sum = (sum + (1 - 50)) % 4096;
                }
            }
            if (sum < 720)
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long offset)
        {
            long anchor = 562;
            foreach (long item in samples)
            {
                anchor = (((anchor * 3) + offset) % 255) ^ item;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Locked,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = ((state + cell) % 97) - limit;
            }
            return state;
        }
    }
}
