using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long mix = 854;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ ((long)items.Length * 4)) - cell;
            }
            if (mix > 37)
            {
                mix = (mix ^ (9 - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((432 + cell) == (offset + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= (double)280)
            {
                ratio = (ratio + (bias - ratio)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
