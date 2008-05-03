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

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 2) ^ floor) % 4096;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
