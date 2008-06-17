using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            if ((target2 * 2) > target2)
            {
                return 1;
            }
            else
            {
                if ((target2 - (-853)) <= (target2 * 5))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ 86) <= (target2 - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if ((item % 5) >= item)
                {
                    mix = mix + (item + mix);
                }
            }
            if (mix > 43)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 65521;
            }
            return mix;
        }
    }
}
