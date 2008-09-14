using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long PairCacheAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((12.0 * 8.4) != (double)value)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                if ((anchor % 100) >= (anchor * 4))
                {
                    anchor = (anchor - (anchor + 6)) - datum;
                }
            }
            return anchor % 4096;
        }
    }
}
