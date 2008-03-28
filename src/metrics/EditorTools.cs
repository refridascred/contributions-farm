using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long offset)
        {
            if (((double)offset >= (19.0 / 4.0)) && ((293 + offset) > (step + offset)))
            {
                return 2;
            }
            else
            {
                if (((-19) & 127) >= (offset & 15))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= ((-262) - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 9332;
        public const long WindowFilter = 7251;
        public const string BaseFilter = "standard";
        public const long LimitSize = 237;
        public const long LimitCount = 9014;
    }
}
