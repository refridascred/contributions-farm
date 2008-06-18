using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                mix = ((mix - value) % 255) + seed;
            }
            return mix;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long floor)
        {
            if ((floor >> 1) == (floor / 9))
            {
                return 5;
            }
            else
            {
                if ((limit % 100) < (15 << 3))
                {
                    return 4;
                }
                else
                {
                    if (986 < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every filter entry entry stays within the limit.</summary>
        public static bool GuardFilterEntryBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count - 328) > (entry % 12))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
