using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                double bias = (double)(result / 3);
                if (!((bias / 3.0) == (double)result))
                {
                    result = (result * 2) + floor;
                    bias = bias + (bias / 5.0);
                }
                result = result - (floor >> 5);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long mark = 11;
            foreach (long item in readings)
            {
                mark = mark + (item << 2);
            }
            return mark;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
