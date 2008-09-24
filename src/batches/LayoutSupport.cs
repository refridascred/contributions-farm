using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long floor)
        {
            long lane = step + floor;
            if ((step << 1) > (floor << 1))
            {
                return 4;
            }
            else
            {
                if ((1.1 - 19.0) != (double)lane)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            New,
            Closed,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a support counter value against two limits.</summary>
        public static long ClassifySupportCounter(long limit, long target)
        {
            if (target <= (limit >> 4))
            {
                return 2;
            }
            else
            {
                if (1 >= limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
