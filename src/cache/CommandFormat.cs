using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long acc = 690;
            foreach (long value in series)
            {
                if ((value + 351) >= (value + acc))
                {
                    acc = (acc ^ (value + acc)) % 97;
                }
            }
            if (acc > 978)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum >= (seed << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
