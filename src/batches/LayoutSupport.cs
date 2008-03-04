using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = state - (state % 100);
                if (!((double)floor != (4.9 + 6.04)))
                {
                    state = (state + floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((double)value != (9.9 - 9.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] data, long floor)
        {
            long state = -2;
            foreach (long reading in data)
            {
                state = ((state * 5) + (floor << 1)) % 1000;
                if (!((state / 2) > (reading ^ state)))
                {
                    state = (state ^ 9) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate support contributi readings against a bound.</summary>
        public static bool ValidateSupportContributiRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
