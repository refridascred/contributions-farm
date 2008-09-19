using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format session pairs that satisfy a relation.</summary>
        public static long CompareFormatSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor << 2) ^ anchor;
                long step = target;
                if ((double)anchor == (5.05 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (target + step)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (0 - 21)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample * 3) >= ((-2) ^ seen)) && (((limit & 127) != (limit & 1)) || (limit > sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
