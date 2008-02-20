using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((bound + 6) < seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long step)
        {
            long delta = bound - step;
            if ((step >> 3) < delta)
            {
                return 1;
            }
            else
            {
                if ((step - delta) != (step + step))
                {
                    return 3;
                }
                else
                {
                    if (delta > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 / 4.0) <= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
