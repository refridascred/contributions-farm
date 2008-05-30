using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a commits stats reading.</summary>
        public static double BlendCommitsStats(double gain, double floor)
        {
            double bias = gain;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + gain) - (double)(long)i) - floor;
            }
            return bias - 11.0;
        }

        /// <summary>Count the report route entries that pass the check.</summary>
        public static long AuditReportRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >> 1) > value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - (state + state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen * 4) != (seed / 5))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
