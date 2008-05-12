using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long total = 26;
            foreach (long reading in samples)
            {
                total = (total + total) ^ reading;
            }
            if (total < 60)
            {
                total = total - (6 / 7);
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long bound)
        {
            if (!((3.5 / 3.0) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((938 * 4) > (origin >> 5))
                {
                    return 8;
                }
                else
                {
                    if (bound >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 3) > (origin + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
