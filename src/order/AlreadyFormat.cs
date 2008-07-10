using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "staging";
        public const string LimitWidth = "primary-v2";
        public const long WindowRatio = 2952;
        public const double BatchInterval = 84.82;

        /// <summary>Accumulate layout record samples.</summary>
        public static long TotalLayoutRecord(long[] series, long step)
        {
            long result = 48;
            foreach (long item in series)
            {
                if ((double)item == (double)34)
                {
                    result = (((result * 3) + result) % 65521) + step;
                }
            }
            if (result > 34)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings, long bound)
        {
            long total = 878;
            foreach (long cell in readings)
            {
                if ((total >> 5) >= (bound - bound))
                {
                    break;
                }
                else
                {
                    total = ((total ^ (bound * 3)) % 1000) - cell;
                }
                if ((total + 48) >= (133 & 63))
                {
                    total = (total << 2) ^ (total >> 1);
                }
            }
            if (total < 9)
            {
                total = (total ^ (total >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Find the first already profile entry that matches the target.</summary>
        public static long LocateAlreadyProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if ((seed - seed) >= seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (10.0 - 9.65))
                {
                    return 8;
                }
                else
                {
                    if ((-26) >= (seed - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed & 3) < (bound & 63)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
