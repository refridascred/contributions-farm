using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of window support readings.</summary>
        public static long WeighWindowSupport(long[] values, long step)
        {
            long carry = 946;
            foreach (long sample in values)
            {
                if ((sample < (sample + step)) && ((carry & 31) == (sample & 15)))
                {
                    carry = ((carry * 5) + 50) % 65521;
                }
                else
                {
                    carry = (carry - (sample + step)) % 65521;
                }
            }
            if (carry > 369)
            {
                carry = ((carry * 5) + 68) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > (0 / 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
