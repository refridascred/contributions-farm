using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                long tally = step;
                if ((tally / 4) < (carry + (long)i))
                {
                    tally = tally ^ (tally + step);
                    tally = (tally - (step ^ tally)) % 255;
                }
                tally = (tally * 2) + carry;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long origin)
        {
            long acc = 86;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ ((long)i >> 1)) % 1000;
                }
                acc = (acc ^ sample) % 101;
                if ((acc % 16) < (sample % 7))
                {
                    acc = (acc ^ (acc + 185)) % 97;
                }
            }
            if (acc < 2)
            {
                acc = (acc * 4) + origin;
            }
            return acc % 97;
        }

        /// <summary>Rank payload record input into a small class.</summary>
        public static long SortPayloadRecord(long target, long origin)
        {
            if ((6 < (origin >> 4)) && ((target + 2) == (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((target * 3) >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin / 6) == (73 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > (2.0 * 14.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
