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

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double ratio = span + (4.0 * 0.4);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + 17.0) + (double)(long)i) + rate;
            }
            return ratio + span;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings, long step)
        {
            long state = -1;
            foreach (long value in readings)
            {
                state = ((state << 2) ^ (state - 1)) + step;
                if (1.2 <= (double)state)
                {
                    state = (state + (state + (long)readings.Length)) % 65521;
                }
                if ((state ^ value) != (value << 2))
                {
                    break;
                }
            }
            return state;
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
