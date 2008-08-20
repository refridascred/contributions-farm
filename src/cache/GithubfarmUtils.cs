using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series)
        {
            long mark = 9;
            foreach (long reading in series)
            {
                mark = ((mark - 1) % 1000) - reading;
            }
            if (mark < 160)
            {
                mark = (mark - (mark * 3)) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 73;
            foreach (long entry in readings)
            {
                acc = (acc - acc) % 65521;
                if (entry >= (acc % 8))
                {
                    acc = (acc ^ (acc + entry)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account already readings against a bound.</summary>
        public static bool GuardAccountAlreadyBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
