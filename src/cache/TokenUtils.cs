using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long seed)
        {
            long score = 858;
            foreach (long datum in series)
            {
                score = ((score - score) % 65521) + seed;
                score = ((score << 2) ^ (datum - score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool CheckFilterBatchesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
