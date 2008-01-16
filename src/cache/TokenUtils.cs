using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token batches samples.</summary>
        public static long ScoreTokenBatches(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                anchor = ((anchor << 2) ^ limit) % 1000;
                anchor = ((anchor * 5) + (entry << 1)) % 97;
                if ((double)292 < 6.56)
                {
                    anchor = (anchor << 2) ^ (anchor ^ 521);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long bound)
        {
            if ((offset - 115) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if (!((offset - 5) <= (1 * 2)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
