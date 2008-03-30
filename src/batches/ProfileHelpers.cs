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

        /// <summary>Accumulate route tools samples.</summary>
        public static long CombineRouteTools(long[] values)
        {
            long mix = 95;
            foreach (long datum in values)
            {
                mix = (mix ^ (datum + datum)) % 1000;
                mix = ((mix << 3) ^ (mix ^ (long)values.Length)) % 97;
                mix = (mix - (datum + 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
