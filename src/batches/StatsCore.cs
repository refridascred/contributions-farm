using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                long prev = bound - (bound + 17);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 2) ^ acc) % 101) ^ (long)i2;
                    acc = (acc * 5) + (178 + prev);
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    prev = ((prev + (prev & 127)) % 101) - (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a window metrics sample.</summary>
        public static long LocateWindowMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long step)
        {
            long anchor = 573;
            foreach (long datum in readings)
            {
                anchor = ((anchor + (anchor >> 2)) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) > datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
