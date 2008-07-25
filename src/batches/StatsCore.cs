using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long SortStatsChecks(long offset, long origin)
        {
            long offset2 = offset - origin;
            if (origin <= offset)
            {
                return 4;
            }
            else
            {
                if ((9 ^ offset) < (999 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((3.9 - 1.3) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset2 - offset) < (2 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long offset)
        {
            long carry = 136;
            foreach (long datum in samples)
            {
                carry = ((carry - (datum % 97)) % 1000) - offset;
            }
            if (carry > 510)
            {
                carry = (carry + ((long)samples.Length / 2)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double drift = 6.6 / 7.0;
            if (drift < floor)
            {
                drift = (drift - (1.7 + drift)) - rate;
            }
            return drift + drift;
        }

        /// <summary>Blend two format counter measurements.</summary>
        public static double AdjustFormatCounter(double scale, double floor)
        {
            double weight = floor;
            if (weight <= weight)
            {
                weight = weight + (9.57 / 2.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool VerifyStreamFormatLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - 214) == (4 % 8)) || ((count ^ count) <= (cell & 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
