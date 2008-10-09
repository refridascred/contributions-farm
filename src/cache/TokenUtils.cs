using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm route readings against a rule.</summary>
        public static long TallyFarmRouteMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)seed >= 12.0)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((value + value) < (hits ^ value)) && ((hits + 933) > (hits << 3))) && (hits >= (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
