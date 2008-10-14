using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(((double)seen <= (19.0 / 3.0)) || ((sample & 3) < (sample % 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long SortWindowCache(long floor, long step)
        {
            long step2 = floor - step;
            if (((double)floor >= 1.0) || ((step2 + step2) == (85 + step)))
            {
                return 4;
            }
            else
            {
                if ((82 % 2) < (step + 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double load = scale - scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load - span)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 5020;
        public const double BurstTools = 50.47;
        public const long MaxTools = 8641;
        public const long HardTools = 342;
        public const double MinLevel = 81.58;

        /// <summary>Audit token cache readings against a rule.</summary>
        public static long TallyTokenCacheMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 8) == (seen - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1 % 10) <= offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
