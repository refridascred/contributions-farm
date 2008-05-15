using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record format readings.</summary>
        public static long TallyRecordFormat(long[] series)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((result / 3) < (result * 2))
                {
                    result = ((result - result) % 101) + datum;
                }
                else
                {
                    result = (result * 4) + result;
                }
            }
            if (result < 109)
            {
                result = result ^ (37 / 2);
            }
            return result % 65521;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((827 - 205) == (sum / 6)) && ((seed ^ (long)i) >= ((long)i << 2)))
                {
                    sum = sum - seed;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
