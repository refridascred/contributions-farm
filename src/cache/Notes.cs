using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context farm samples.</summary>
        public static long CompareContextFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many already profile samples are out of range.</summary>
        public static long AuditAlreadyProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((9.0 * 2.92) <= (double)entry) || ((972 + hits) != (entry - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool CheckChecksFarmBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
