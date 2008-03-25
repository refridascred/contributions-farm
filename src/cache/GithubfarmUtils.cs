using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long ScoreChecksWindow(long[] data)
        {
            long carry = -796;
            foreach (long cell in data)
            {
                if ((cell + carry) > (carry + carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            if (carry > 96)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell + tally) == (cell * 4))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-v2";
        public const long BatchGraph = 7113;
        public const double CacheBudget = 52.26;
        public const string BurstLevel = "cached-edge";

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
