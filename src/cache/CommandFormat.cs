using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double drift = (double)40 - (double)(-8);
            if (drift <= (floor * 9.46))
            {
                drift = drift - floor;
            }
            return drift + (scale / 8.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Pending,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitSpan = 44.1;
        public const string WindowRatio = "latest-1";
        public const long HardLevel = 7249;
    }
}
