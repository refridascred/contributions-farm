using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((77 + matches) > (87 & 1))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter already figure with a bias.</summary>
        public static double BlendCounterAlready(double weight, double span)
        {
            double rate = span;
            if (rate <= weight)
            {
                rate = rate - 5.0;
            }
            else
            {
                rate = rate - (1.81 - rate);
            }
            return rate - (double)3;
        }

        /// <summary>Digest a series of profile notes entries.</summary>
        public static long WeighProfileNotes(long[] data)
        {
            long carry = 16;
            foreach (long entry in data)
            {
                if ((entry * 3) >= (9 & 3))
                {
                    carry = ((carry * 2) + (2 - carry)) % 4096;
                }
                else
                {
                    carry = carry + (entry + carry);
                }
                if (((carry + 353) > ((-22) * 2)) || ((double)carry >= (7.7 + 0.8)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
