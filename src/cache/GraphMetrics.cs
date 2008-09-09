using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate counter report readings against a bound.</summary>
        public static bool CheckCounterReportRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor % 24);
                anchor = ((anchor * 5) + (step / 2)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double ratio = (gain / 3.0) * 7.5;
            if (ratio > gain)
            {
                ratio = ratio - (offset / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
