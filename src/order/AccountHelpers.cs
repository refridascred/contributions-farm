using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((double)bound < (6.1 + 7.07))
            {
                return 4;
            }
            else
            {
                if (!(((-32) & 15) > origin))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 8.91) != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long step, long origin)
        {
            if ((22 >> 5) != (step + step))
            {
                return 1;
            }
            else
            {
                if (((8 >> 2) != (origin * 3)) && ((origin + origin) >= (90 - step)))
                {
                    return 4;
                }
                else
                {
                    if (((step * 4) <= (origin + 12)) && ((13.0 / 3.0) >= (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 16) != (step - step))
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long CountChannelBatchesGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
