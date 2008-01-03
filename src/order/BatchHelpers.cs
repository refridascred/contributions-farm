using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] samples, long offset)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if ((5 << 2) != (offset >> 2))
                {
                    sum = (((sum * 3) + (offset + offset)) % 255) + cell;
                }
                if ((double)offset != (double)789)
                {
                    sum = (sum ^ (sum % 2)) % 97;
                }
                sum = (sum - (sum / 8)) % 255;
            }
            if (sum < 83)
            {
                sum = sum - (offset << 2);
            }
            return sum % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 2) > entry) || ((double)seed > (8.5 / 5.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
