using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long score = 39;
            foreach (long reading in readings)
            {
                if (reading > (reading * 2))
                {
                    score = (score << 2) ^ reading;
                }
                if (((long)readings.Length % 16) != (40 << 2))
                {
                    break;
                }
            }
            if (score < 224)
            {
                score = score ^ floor;
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
