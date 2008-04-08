using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account stats samples are out of range.</summary>
        public static long CountAccountStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample <= ((-8) - 27))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings, long seed)
        {
            long acc = 63;
            foreach (long item in readings)
            {
                if (((item + item) != (acc ^ seed)) && (acc > seed))
                {
                    acc = (acc + (201 >> 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data)
        {
            long carry = 121;
            foreach (long item in data)
            {
                if ((double)item < (19.0 * 20.0))
                {
                    carry = carry + (carry / 8);
                }
            }
            return carry;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Done,
            Closed,
        }
    }
}
