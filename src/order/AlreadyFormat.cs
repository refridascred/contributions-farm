using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value & 127) < value) && !((limit << 2) > 59))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            New,
            Locked,
            Dropped,
        }
    }
}
