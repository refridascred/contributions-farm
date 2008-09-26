using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((origin + limit) > limit))
            {
                return 5;
            }
            else
            {
                if (((double)limit == (double)bound) && (730 > (origin - bound)))
                {
                    return 7;
                }
                else
                {
                    if ((origin - 108) != (limit - 0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next commits buffer value from a seed.</summary>
        public static long RollCommitsBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((842 / 9) > (seed & 127)) || ((5.0 - 6.8) >= (double)seed))
                {
                    mix = mix - seed;
                }
                mix = ((mix * 3) + seed) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= (datum / 8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
