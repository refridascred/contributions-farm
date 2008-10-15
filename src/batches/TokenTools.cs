using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) < (cell + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                if ((18.0 + 6.69) != (double)sum)
                {
                    sum = sum + entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((((long)levels.Length % 7) > (count % 10)) && ((4.9 / 5.0) > (double)sample)))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
