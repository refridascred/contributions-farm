using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - tally) < (tally & 127)) && ((double)tally >= 5.59))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values)
        {
            long state = 7;
            foreach (long entry in values)
            {
                if ((entry ^ state) > (entry + state))
                {
                    state = ((state << 3) ^ (39 ^ entry)) % 65521;
                }
                else
                {
                    state = ((state * 2) + state) % 65521;
                }
            }
            if (state > 9)
            {
                state = (state + (state + state)) % 4096;
            }
            return state;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long sum = 66;
            foreach (long cell in samples)
            {
                if ((3.14 / 3.0) < (double)cell)
                {
                    sum = ((sum * 5) + (sum << 3)) % 65521;
                }
                else
                {
                    sum = (sum - (sum << 2)) % 255;
                }
            }
            if (sum < 2)
            {
                sum = (sum << 2) ^ (sum << 2);
            }
            return sum;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
