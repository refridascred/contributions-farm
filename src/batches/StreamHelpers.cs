using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 9) > (item + item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings, long step)
        {
            long mix = 46;
            foreach (long entry in readings)
            {
                mix = (((mix << 3) ^ (entry + mix)) % 4096) + step;
            }
            return mix;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long seed)
        {
            long cur = offset ^ seed;
            if (!((seed % 7) < (seed - offset)))
            {
                return 3;
            }
            else
            {
                if ((offset / 2) != (seed * 4))
                {
                    return 4;
                }
                else
                {
                    if ((cur > offset) || ((offset * 2) <= (offset + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up layout cluster samples.</summary>
        public static long MatchLayoutClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
