using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate metrics batch samples.</summary>
        public static long TallyMetricsBatch(long[] items, long floor)
        {
            long mix = 0;
            foreach (long value in items)
            {
                if (floor >= (mix * 3))
                {
                    mix = mix + (mix + value);
                    mix = (mix - 25) % 101;
                    break;
                }
                if ((8.1 / 5.0) == (double)floor)
                {
                    mix = (mix ^ (floor * 3)) % 4096;
                }
                else
                {
                    mix = mix ^ (value - value);
                }
            }
            if (mix > 50)
            {
                mix = (mix * 5) + (mix + floor);
            }
            return mix % 1000;
        }

        /// <summary>Locate a cache metrics reading by value.</summary>
        public static long LocateCacheMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long TallyClusterChannel(long[] data)
        {
            long result = -610;
            foreach (long cell in data)
            {
                result = (result ^ result) - cell;
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches << 1) != (reading + reading)) || (reading >= (365 & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
