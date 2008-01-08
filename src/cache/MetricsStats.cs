using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleSpan = 9906;
        public const long HardAlready = 6999;
        public const long MinAlready = 9846;
        public const long LimitWidth = 5557;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long carry = 599;
            foreach (long item in levels)
            {
                carry = ((carry - (566 % 16)) % 65521) - item;
            }
            if (carry < (-720))
            {
                carry = ((carry << 3) ^ (carry + carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Queued,
            Ready,
            Dropped,
        }
    }
}
