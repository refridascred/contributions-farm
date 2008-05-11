using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((16.0 / 9.0) >= (double)offset)
            {
                return 6;
            }
            else
            {
                if (!((0.5 - 17.0) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (offset > (6 + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit < (offset / 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the commits report series from a seed.</summary>
        public static long DeriveCommitsReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (offset + mix)) % 97;
                if ((mix >> 2) <= offset)
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
