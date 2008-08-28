using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((mark << 1) != (origin << 1)))
                {
                    mark = mark - (origin % 24);
                }
                long lane = (long)i;
                if ((lane - origin) > (mark & 127))
                {
                    mark = ((mark << 2) ^ (9 + (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Count { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double load = floor;
            for (int i = 0; i < 6; i++)
            {
                load = (load + 6.0) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Digest a series of counter command entries.</summary>
        public static long WeighCounterCommand(long[] data)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length > (double)312)
                {
                    state = (state ^ (sample / 3)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
