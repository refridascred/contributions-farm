using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double load = 3.47;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - bias) - (double)(long)i) - offset;
            }
            return load + 5.09;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Closed,
            Failed,
            Active,
            Retry,
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
