using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((seed & 7) >= carry))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
                if ((carry >= (long)i) && ((carry << 2) > carry))
                {
                    carry = ((carry * 3) + seed) % 97;
                    carry = (carry - seed) % 101;
                }
                else
                {
                    carry = carry - seed;
                }
                carry = (carry - (seed % 12)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long state = 480;
            foreach (long reading in levels)
            {
                state = state + ((-42) % 2);
                if (((long)levels.Length - reading) > reading)
                {
                    state = state + (state ^ reading);
                }
                if ((double)reading != (10.0 / 7.0))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = ((state * 2) + (state & 63)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
