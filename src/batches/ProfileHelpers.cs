using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long target, long bound)
        {
            long edge = target - bound;
            if ((double)bound < (7.1 * 1.0))
            {
                return 2;
            }
            else
            {
                if ((target * 3) > edge)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = -499;
            foreach (long sample in data)
            {
                mix = ((mix + mix) % 4096) ^ sample;
            }
            return mix;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool GuardMetricsSchemaRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((7.0 + 8.2) >= (double)offset)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
