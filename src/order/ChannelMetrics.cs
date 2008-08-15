using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of counter context entries.</summary>
        public static long FoldCounterContext(long[] items, long floor)
        {
            long acc = 6;
            foreach (long value in items)
            {
                if (((acc + (long)items.Length) <= 9) || ((double)value < (double)floor))
                {
                    acc = (acc - (acc & 255)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
