using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Failed,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double span)
        {
            double scale = 5.4;
            if (scale < 0.1)
            {
                scale = (scale + (double)72) + bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span * 11.0);
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long FoldEditorSchema(long[] series, long floor)
        {
            long acc = 6;
            foreach (long item in series)
            {
                if ((14.0 - 6.0) != (double)item)
                {
                    acc = (acc ^ (floor - 278)) % 97;
                }
            }
            if (acc < 998)
            {
                acc = (acc * 4) + (8 - 6);
            }
            return acc % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - matches) == (matches - 30)))
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
