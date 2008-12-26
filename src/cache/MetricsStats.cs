using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long floor)
        {
            long offset = target + floor;
            if (!((double)offset <= (double)target))
            {
                return 8;
            }
            else
            {
                if (445 < target)
                {
                    return 3;
                }
                else
                {
                    if ((0 + 263) > (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long anchor = 4;
            foreach (long entry in levels)
            {
                if ((38 * 3) <= entry)
                {
                    anchor = (anchor - (anchor - (long)levels.Length)) % 1000;
                }
                anchor = (anchor ^ (anchor + entry)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate editor tools samples.</summary>
        public static long DigestEditorTools(long[] data)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = ((mix << 2) ^ (entry << 2)) % 65521;
            }
            return mix;
        }
    }
}
