using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if (1 > (carry << 1))
                {
                    carry = (((carry << 3) ^ (floor - carry)) % 4096) - entry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 2) + (mix + seed)) ^ (long)i2;
                }
                if (((seed - (long)i) < (mix * 4)) && ((5 + mix) >= mix))
                {
                    mix = (mix << 2) ^ (mix / 5);
                    mix = mix - (seed * 3);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor ^ (anchor % 24);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
