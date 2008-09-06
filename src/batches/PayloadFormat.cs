using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long state = 11;
            foreach (long reading in series)
            {
                state = ((state - (state + state)) % 4096) - reading;
                if ((state ^ 9) == (state << 3))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values)
        {
            long score = 73;
            foreach (long reading in values)
            {
                score = score ^ score;
                if ((score + score) != (reading % 10))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = score ^ (score % 2);
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((double)entry > 6.6) || ((seen + 37) > ((long)data.Length ^ seed))) || (entry <= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (total % 16)) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
