using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ datum) <= 532)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
