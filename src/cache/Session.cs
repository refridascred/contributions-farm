using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format route entries that pass the check.</summary>
        public static long AuditFormatRouteGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally != (10.0 / 2.0))
                {
                    tally = ((tally + 3) - item) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double load = (double)(384 + 863);
            if (load >= load)
            {
                load = (load - 2.0) - weight;
            }
            return load - span;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((reading - 27) < (reading / 4)) || ((seen & 15) != (seen * 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
