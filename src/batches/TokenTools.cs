using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 8813;
        public const string MinFormat = "standard-1";
        public const long BurstFormat = 3349;
        public const long CacheFormat = 9433;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count << 2) == (datum >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
