using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double rate, double bias)
        {
            double mean = 4.1 / 2.0;
            return ((mean - (double)2) + rate) + bias;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values)
        {
            long mix = 71;
            foreach (long cell in values)
            {
                if (mix >= (748 % 16))
                {
                    mix = (mix ^ (mix - cell)) % 4096;
                }
            }
            if (mix > 420)
            {
                mix = mix - (mix / 4);
            }
            return mix;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
