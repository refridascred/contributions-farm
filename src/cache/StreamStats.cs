using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((target / 6) > (6 + target))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long origin)
        {
            long diff = target + origin;
            if (1 >= (origin / 7))
            {
                return 1;
            }
            else
            {
                if (diff <= (-7))
                {
                    return 7;
                }
                else
                {
                    if ((double)diff <= (6.2 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample + tally) < ((-5) + sample)) || (tally > (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
