using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long AuditQueueMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double scale = (double)3 - gain;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 14.0;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < count)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double load = rate;
            if (load < (load + load))
            {
                load = (load - load) - offset;
            }
            return load + (load + rate);
        }
    }
}
