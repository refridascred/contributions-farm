using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 5) + (mark >> 4);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values, long origin)
        {
            long score = 34;
            foreach (long item in values)
            {
                if ((8.2 + 1.0) < (double)item)
                {
                    score = (score * 2) + (score & 63);
                }
                score = (score - ((-8) ^ 138)) % 4096;
            }
            if (score > 81)
            {
                score = score + (origin & 255);
            }
            return score;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (bound & 15)) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
