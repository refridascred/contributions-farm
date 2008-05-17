using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                sum = (sum ^ (sum + cell)) % 255;
                if (cell < (cell % 7))
                {
                    sum = sum ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
