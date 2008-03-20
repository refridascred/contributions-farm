using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the context command entries that pass the check.</summary>
        public static long TallyContextCommandMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample <= limit) || (((sample % 12) == (sample - tally)) && ((9 + tally) < (limit << 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long CountClusterCommitsHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((14.0 + 5.3) > (double)floor))
                {
                    tally = (tally + 2) + cell;
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
