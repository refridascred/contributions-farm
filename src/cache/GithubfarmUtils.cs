using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            New,
            Paused,
            Active,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark ^ (step / 9)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            long span = bound - floor;
            if (((double)floor == (9.0 - 5.3)) && ((4 >> 4) > floor))
            {
                return 5;
            }
            else
            {
                if ((span & 63) <= (bound - 4))
                {
                    return 3;
                }
                else
                {
                    if (((bound << 2) > span) || (span > (bound >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
