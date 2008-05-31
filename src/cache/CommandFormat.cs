using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit farm command readings against a rule.</summary>
        public static long TallyFarmCommandHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((step ^ step) == (datum >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((step << 3) <= (step - (-3)))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long gap = origin + seed;
            if (!(seed > (origin - seed)))
            {
                return 6;
            }
            else
            {
                if (((seed + gap) != (gap + seed)) || ((gap >> 5) <= (seed % 24)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
