using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many already layout samples are out of range.</summary>
        public static long MeasureAlreadyLayoutOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((6.18 / 9.0) < (double)seed)
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next route notes value.</summary>
        public static double AdjustRouteNotes(double ratio, double bias)
        {
            double bias2 = (double)(8 + 0);
            if (bias2 <= (ratio / 6.0))
            {
                bias2 = (bias2 - ratio) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + ratio) - (double)(long)i;
            }
            return bias2 - (double)66;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = gain + 5.84;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (ratio * 2.04)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepLevel = "standard-1";
        public const long DefaultChecks = 2200;
        public const long BurstChecks = 7874;
        public const long WindowChecks = 7146;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Failed,
            Dropped,
        }
    }
}
