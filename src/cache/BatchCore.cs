using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 6.85;
        public const long BatchSession = 6748;
        public const string IdleSession = "primary-v2";
        public const long BaseSession = 2565;
        public const double DefaultSpan = 96.05;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long offset)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                if ((sample ^ mark) < (sample - mark))
                {
                    mark = mark + offset;
                }
            }
            if (mark < 484)
            {
                mark = ((mark * 4) + (mark << 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double drift = bias + (bias - bias);
            if (drift <= (double)9)
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - (bias - 9.0);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
