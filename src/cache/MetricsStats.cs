using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) == (tally * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
