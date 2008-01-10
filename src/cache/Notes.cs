using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits > (10.0 / 2.0))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two already tools measurements.</summary>
        public static double BlendAlreadyTools(double bias, double span)
        {
            double ratio = (bias / 3.0) + (bias - span);
            if (ratio < (double)31)
            {
                ratio = ratio - 6.6;
            }
            else
            {
                ratio = ratio + (bias + span);
            }
            return ratio - (15.0 * 2.28);
        }

        /// <summary>Roll a notes channel counter forward.</summary>
        public static long SeriesNotesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result + (bound >> 1)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
