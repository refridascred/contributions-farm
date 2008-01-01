using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long target, long bound)
        {
            long next = target + bound;
            if ((bound + bound) >= (813 & 127))
            {
                return 8;
            }
            else
            {
                if ((target & 7) >= (target & 1))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound) <= (next >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.0 / 4.0) <= (double)bound)
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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((double)step < (19.0 - 15.0)) && ((seen >= (seen + 2)) || ((6.0 * 4.4) >= (double)seen)))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total * 5) + total;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.0 - 1.66))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = (rate * 7.1) - (double)75;
            if (rate2 <= (offset * 3.9))
            {
                rate2 = rate2 + (rate2 - offset);
            }
            else
            {
                rate2 = rate2 + (double)582;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate2 / 5.0);
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = (offset / 3.0) + gain;
            if (bias < 8.8)
            {
                bias = bias - (offset / 2.0);
            }
            return bias + (gain * 13.0);
        }
    }
}
