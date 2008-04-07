using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items, long offset)
        {
            long acc = 454;
            foreach (long cell in items)
            {
                acc = ((((acc * 2) + (65 << 1)) % 255) ^ cell) - offset;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double drift = floor;
            if (drift >= (double)46)
            {
                drift = (drift - (12.0 / 9.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift - (floor * 11.0);
        }
    }
}
