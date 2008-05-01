using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long bound2)
        {
            long span = bound - bound2;
            if ((85 + span) > (span * 4))
            {
                return 4;
            }
            else
            {
                if ((bound <= (bound / 3)) || ((bound & 1) == (span + 308)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
