using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a graph commits sample.</summary>
        public static long LocateGraphCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer notes reading.</summary>
        public static double AdjustBufferNotes(double bias, double bias2)
        {
            double drift = bias / 8.0;
            if (drift > drift)
            {
                drift = drift + (3.2 + drift);
            }
            else
            {
                drift = drift - (drift - bias2);
            }
            return drift + (bias * 1.0);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((sample << 2) == (sample - tally)) || (sample < (tally % 64))) || (((tally / 4) < sample) && ((sample + tally) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
