using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first layout token entry that matches the target.</summary>
        public static long LocateLayoutTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((double)count < (6.8 / 5.0)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a report channel counter forward.</summary>
        public static long IterateReportChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
