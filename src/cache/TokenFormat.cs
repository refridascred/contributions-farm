using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric already input into a small class.</summary>
        public static long ClassifyMetricAlready(long offset, long bound)
        {
            if (bound >= (bound + offset))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) != (offset + 763))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
