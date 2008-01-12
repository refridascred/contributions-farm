using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "latest-edge";
        public const long StepRoute = 1430;
        public const long MinRoute = 2963;
        public const long HardRoute = 2616;

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double floor)
        {
            double gain = rate - rate;
            if (gain <= (double)31)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (floor - rate);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long CountRouteEditorGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + offset) >= (reading % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry <= (tally + 395))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
