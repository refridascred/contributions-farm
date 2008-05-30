using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 18;
            foreach (long value in values)
            {
                state = (state << 2) ^ value;
            }
            return state;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (diff > floor)
            {
                return 8;
            }
            else
            {
                if (((diff << 3) != (floor + diff)) || ((8 ^ floor) >= floor))
                {
                    return 0;
                }
                else
                {
                    if ((17 / 4) == (limit + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8283;
        public const double CacheLayout = 25.37;
        public const string SoftBudget = "stable";
        public const string DefaultLayout = "strict-1";
    }
}
