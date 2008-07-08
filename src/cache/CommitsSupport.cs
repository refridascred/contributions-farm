using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ cell) < (count / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double ratio, double bias)
        {
            double load = (double)(983 + 71);
            if (load <= bias)
            {
                load = (load - bias) - ratio;
            }
            return load + (load * 3.2);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (3.9 >= (double)cell)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i ^ (-80))) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length > (hits - 764))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
