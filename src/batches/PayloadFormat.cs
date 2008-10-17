using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of route commits entries.</summary>
        public static long ScoreRouteCommits(long[] values)
        {
            long state = 164;
            foreach (long value in values)
            {
                if (((state * 2) >= (state >> 5)) || ((7 >> 4) <= (9 ^ state)))
                {
                    state = ((state ^ (44 - state)) % 97) - value;
                }
            }
            return state;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long acc = 42;
            foreach (long datum in levels)
            {
                acc = ((acc << 2) ^ (datum / 4)) % 255;
            }
            if (acc < 49)
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc % 65521;
        }
    }
}
