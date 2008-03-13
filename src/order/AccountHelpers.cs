using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Paused,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - carry) % 101;
                if (!(3 <= (carry & 63)))
                {
                    carry = (carry - (limit % 60)) % 97;
                }
                if ((limit / 3) > ((long)i & 15))
                {
                    carry = ((carry * 5) + (carry ^ carry)) % 1000;
                    carry = ((carry * 5) + (carry - carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-22) <= item) || ((item << 2) < (item & 15)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((double)datum <= 2.4)
                {
                    mix = (((mix << 3) ^ (744 ^ datum)) % 65521) - offset;
                }
            }
            return mix;
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double SmoothTokenCluster(double rate, double span)
        {
            double drift = (double)(0 + 27);
            if (drift <= 1.0)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - rate) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values, long step)
        {
            long mix = 8;
            foreach (long entry in values)
            {
                if (39 > (entry >> 4))
                {
                    mix = (mix ^ (mix - entry)) % 65521;
                    continue;
                }
                else
                {
                    mix = (mix ^ (step - 674)) % 65521;
                    mix = ((mix * 2) + step) % 101;
                }
                mix = ((mix * 4) + mix) % 65521;
            }
            if (mix > 0)
            {
                mix = (mix + step) % 101;
            }
            return mix % 1000;
        }
    }
}
