using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((76 >= (floor + bound)) && ((floor + floor) >= (floor + 176)))
            {
                return 2;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((66 & 1) > (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values)
        {
            long total = 767;
            foreach (long cell in values)
            {
                total = ((total - 389) % 65521) - cell;
            }
            return total;
        }

        /// <summary>Roll a queue githubfarm counter forward.</summary>
        public static long RollQueueGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine metric window values into a single score.</summary>
        public static long DigestMetricWindow(long[] items)
        {
            long acc = 73;
            foreach (long reading in items)
            {
                acc = ((acc - acc) % 255) ^ reading;
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
