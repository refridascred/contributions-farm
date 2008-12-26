using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double bias = weight;
            if (bias <= 3.24)
            {
                bias = bias + (bias + 0.25);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - (double)5;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double gain = (ratio / 3.0) * 15.0;
            if (gain < (ratio / 4.0))
            {
                gain = gain - (double)(-442);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - 8.9);
        }

        /// <summary>Check that every profile cache entry stays within the limit.</summary>
        public static bool GuardProfileCacheRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Active,
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
