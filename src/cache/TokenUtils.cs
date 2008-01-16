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

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long offset)
        {
            if ((step + 2) >= (0 + offset))
            {
                return 8;
            }
            else
            {
                if ((step <= (offset - offset)) && ((5.83 - 1.9) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((step >= (256 - step)) || ((step + (-123)) == (offset & 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step * 3) <= 374) && ((offset ^ 38) == (offset >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
