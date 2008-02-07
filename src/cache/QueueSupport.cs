using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long anchor = -98;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (offset % 2)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long carry = 5;
            foreach (long reading in series)
            {
                if ((double)reading <= (15.0 * 8.2))
                {
                    carry = (carry << 2) ^ (carry + reading);
                }
                else
                {
                    carry = carry - (carry / 6);
                }
            }
            return carry;
        }
    }
}
