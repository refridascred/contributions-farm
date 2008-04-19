using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of report entry readings.</summary>
        public static long CombineReportEntry(long[] items, long target)
        {
            long mix = 164;
            foreach (long reading in items)
            {
                mix = ((mix << 2) ^ (mix + reading)) % 65521;
                if ((3.06 + 10.0) > (double)reading)
                {
                    mix = (mix << 3) ^ target;
                }
                mix = ((mix << 3) ^ (target - reading)) % 97;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 509;
        public const long HardMetrics = 4281;
        public const string RetryMetrics = "legacy";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if (((6 << 2) < (10 + target)) && ((step * 4) == (974 << 2)))
            {
                return 1;
            }
            else
            {
                if (!(target > ((-658) + step)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
