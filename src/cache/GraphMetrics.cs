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

        /// <summary>Iterate the graph stats series from a seed.</summary>
        public static long StepGraphStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((anchor < (target & 7)) || ((target - (long)i) > 841)))
                {
                    anchor = anchor + (target + target);
                }
                anchor = (anchor - ((long)i % 2)) % 1000;
                anchor = (anchor ^ 34) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
