using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
