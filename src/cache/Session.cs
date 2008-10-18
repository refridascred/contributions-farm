using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + tally) <= (tally - 8))
                {
                    tally = ((tally + 3) + item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long TallyProfileLayoutOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(sample <= (sample + (long)values.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                long bound = (target >> 3) + ((long)i << 2);
                if ((mix / 7) < ((long)i + bound))
                {
                    bound = (bound - (bound << 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
