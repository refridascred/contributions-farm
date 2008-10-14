using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits - item) > item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix << 3) ^ seed) - (long)i2;
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] levels, long seed)
        {
            long anchor = 17;
            foreach (long value in levels)
            {
                anchor = (anchor + (3 % 24)) - value;
                anchor = anchor + (anchor - anchor);
                if ((anchor % 5) > (anchor / 5))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + (seed / 5)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Match up channel token samples.</summary>
        public static long MatchChannelTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
