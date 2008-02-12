using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank farm githubfarm input into a small class.</summary>
        public static long BucketFarmGithubfarm(long offset, long floor)
        {
            if ((floor + floor) <= 63)
            {
                return 5;
            }
            else
            {
                if ((double)60 > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) <= (floor >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset << 3) < (floor + 79)) && ((4.5 + 8.6) >= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values, long target)
        {
            long result = 20;
            foreach (long sample in values)
            {
                if ((double)result == (6.0 + 8.0))
                {
                    result = (result + 7) % 97;
                }
                else
                {
                    result = result + (target - sample);
                }
                result = (result + sample) % 4096;
                if ((result < (36 + target)) && ((double)sample <= (double)result))
                {
                    result = ((result << 3) ^ (sample - (-902))) % 255;
                }
                if ((double)target < (6.49 / 7.0))
                {
                    break;
                }
            }
            if (result > 707)
            {
                result = ((result * 4) + target) % 255;
            }
            return result;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 2) ^ result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
