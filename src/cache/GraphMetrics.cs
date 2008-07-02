using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                if (!((value % 60) == (value & 15)))
                {
                    mix = (mix + (value << 3)) % 97;
                    break;
                }
                mix = mix - (value - value);
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length * 4) > (5 << 2))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Done,
            Draft,
            Active,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                if (((double)value <= (14.0 / 6.0)) && (((-277) - 49) < (mix + mix)))
                {
                    mix = (mix << 3) ^ (415 + mix);
                }
                if ((6.2 / 7.0) <= (double)value)
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
