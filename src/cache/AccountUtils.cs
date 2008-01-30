using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank graph stats input into a small class.</summary>
        public static long ClassifyGraphStats(long step, long origin)
        {
            long slot = step + origin;
            if ((9.4 * 16.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if (((slot ^ step) >= (9 + origin)) && ((step << 3) <= slot))
                {
                    return 4;
                }
                else
                {
                    if ((origin < (slot >> 1)) && ((slot - origin) > (step % 60)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 16) >= (slot & 7)) || ((double)30 == (double)slot))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > rate2)
            {
                rate2 = (rate2 - (double)308) - rate;
            }
            return rate2 + 17.0;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - reading) > tally)
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
    }
}
