using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record account value against two limits.</summary>
        public static long BucketRecordAccount(long limit, long floor)
        {
            if ((1.0 / 3.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((limit >= 448) || ((floor + floor) > (limit << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 5) >= (4 + 61))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((15.0 - 2.33) == (double)origin)
                {
                    result = ((result << 3) ^ (551 - result)) % 4096;
                }
                result = (result + 2) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long mix = 71;
            foreach (long item in readings)
            {
                if (3 <= (mix - mix))
                {
                    mix = mix - (item ^ item);
                }
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long target)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                mix = (mix ^ sample) - target;
            }
            if (mix > 875)
            {
                mix = ((mix << 2) ^ (mix / 7)) % 65521;
            }
            return mix;
        }
    }
}
