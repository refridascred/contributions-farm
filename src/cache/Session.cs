using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double floor)
        {
            double scale = (ratio * 20.0) + floor;
            if (scale > (scale * 6.45))
            {
                scale = scale - floor;
            }
            return scale + scale;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long MeasureToolsNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 45) > ((long)items.Length & 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
