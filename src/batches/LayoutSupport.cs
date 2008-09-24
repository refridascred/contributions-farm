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

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long anchor = 409;
            foreach (long item in readings)
            {
                if (((-5) - item) >= 377)
                {
                    anchor = (anchor - (661 / 5)) % 255;
                }
                if ((item * 3) == (item + anchor))
                {
                    anchor = anchor ^ (anchor / 5);
                }
                else
                {
                    anchor = (anchor ^ 0) % 255;
                }
            }
            if (anchor > 322)
            {
                anchor = (anchor + (anchor / 7)) % 1000;
            }
            return anchor;
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
