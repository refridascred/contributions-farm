using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long target)
        {
            long delta = step + target;
            if ((delta + delta) > step)
            {
                return 5;
            }
            else
            {
                if (step > (target - target))
                {
                    return 8;
                }
                else
                {
                    if (((9 << 3) != (target - step)) && (306 < (step + 56)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up layout schema samples.</summary>
        public static long CompareLayoutSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
