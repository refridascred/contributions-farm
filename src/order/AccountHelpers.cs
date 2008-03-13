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

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long anchor = 365;
            foreach (long entry in data)
            {
                anchor = anchor + (anchor + entry);
                if ((entry + 82) < ((-9) + entry))
                {
                    break;
                }
                else
                {
                    anchor = anchor + (anchor - anchor);
                }
                if ((anchor - 954) < 148)
                {
                    anchor = anchor ^ (entry - anchor);
                }
            }
            if (anchor < 797)
            {
                anchor = (anchor + (anchor * 5)) % 101;
            }
            return anchor;
        }
    }
}
