using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Check that every queue checks entry stays within the limit.</summary>
        public static bool ValidateQueueChecksBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next counter stream value.</summary>
        public static double AdjustCounterStream(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)5) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Closed,
            Locked,
            New,
        }
    }
}
