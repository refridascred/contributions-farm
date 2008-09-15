using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) > value)
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

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long TallyMetricChecks(long[] data)
        {
            long total = -64;
            foreach (long cell in data)
            {
                total = ((total * 4) + (total % 64)) + cell;
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
