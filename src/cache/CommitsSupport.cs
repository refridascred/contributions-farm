using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long step)
        {
            long mix = 606;
            foreach (long entry in readings)
            {
                if ((mix & 7) <= mix)
                {
                    mix = (((mix << 3) ^ (312 + mix)) % 1000) - entry;
                }
            }
            if (mix > 885)
            {
                mix = ((mix << 3) ^ (step * 5)) % 4096;
            }
            return mix % 65521;
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

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
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
