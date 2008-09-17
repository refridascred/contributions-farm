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

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = (result + (result & 31)) % 97;
                result = (result * 3) + (offset + offset);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
