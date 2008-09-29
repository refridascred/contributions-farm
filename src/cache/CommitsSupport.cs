using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks context samples.</summary>
        public static long TotalChecksContext(long[] values, long origin)
        {
            long carry = 3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - ((long)i & 31)) % 101;
                }
                if (((1.27 / 3.0) <= (double)origin) || ((origin + cell) < cell))
                {
                    carry = (carry << 2) ^ (cell ^ 42);
                }
                else
                {
                    carry = (carry << 3) ^ (carry - carry);
                }
                carry = (carry + ((long)values.Length & 15)) % 101;
            }
            if (carry < 291)
            {
                carry = (carry << 3) ^ (origin + origin);
            }
            return carry % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + tally) >= tally) && ((5.9 - 6.8) <= (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm payload pair into a bucket.</summary>
        public static long ClassifyGithubfarmPayload(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((7.95 - 1.4) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((seed - floor) != (3 * 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ floor) > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta == (0.2 * 7.8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            if (36 >= (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((step & 31) == (step % 97))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 4) >= (value % 97))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
