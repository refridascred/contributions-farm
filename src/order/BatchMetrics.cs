using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mix = 13;
            foreach (long value in readings)
            {
                if (((double)mix > (double)(-9)) && ((7.3 - 4.0) >= (double)value))
                {
                    mix = (mix << 3) ^ (value + mix);
                }
                else
                {
                    mix = (mix + 37) % 255;
                }
                mix = (mix - mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (origin ^ (-2));
                mix = ((mix * 4) + (38 & 31)) % 65521;
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long limit)
        {
            long total = 4;
            foreach (long reading in items)
            {
                if ((reading >= (838 * 3)) && ((double)limit != (8.0 / 4.0)))
                {
                    total = ((total * 4) + (total / 5)) % 65521;
                    break;
                }
                if ((12.0 >= (double)total) && ((290 + limit) <= (total << 1)))
                {
                    total = (total ^ ((-218) - reading)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound / 9) > (bound2 ^ 969))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 1) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
