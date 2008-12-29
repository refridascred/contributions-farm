using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 80.08;
        public const string MaxQueue = "primary-edge";
        public const double DefaultLevel = 54.58;
        public const long MaxBudget = 3565;

        /// <summary>Adjust a metric farm reading.</summary>
        public static double SmoothMetricFarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (weight / 9.0))
            {
                ratio = (ratio - (double)556) + span;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Idle,
            Closed,
            New,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 2) ^ target;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)2 > (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
