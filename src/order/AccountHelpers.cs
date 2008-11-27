using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first account batch entry that matches the target.</summary>
        public static long SeekAccountBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Retry,
            Active,
            New,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed >= (4 * 4)) && ((seed > (sample + seed)) || ((seed - seed) < (count * 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (((floor >> 3) < (cur / 3)) && (origin > (origin * 2)))
            {
                return 6;
            }
            else
            {
                if ((16 % 8) > (floor * 5))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 3) == (origin - 579)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (cur ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
