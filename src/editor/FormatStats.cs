using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally >= (tally & 7))
                {
                    tally = ((tally + 3) + cell) - offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache channel value from a seed.</summary>
        public static long IterateCacheChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7415;
        public const long LimitPayload = 7507;
        public const long BasePayload = 8378;
    }
}
