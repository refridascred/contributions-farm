using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double bias2 = (double)(21 + 820);
            if (bias2 <= (double)31)
            {
                bias2 = (bias2 + 7.6) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
