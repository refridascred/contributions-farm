using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a already tools counter forward.</summary>
        public static long SeriesAlreadyTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
                if (((49 + offset) != (anchor >> 4)) || ((double)offset <= (10.0 / 5.0)))
                {
                    anchor = ((anchor * 2) + ((long)i - anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor * 4) + step) % 255) + (long)i2;
                    anchor = ((anchor * 2) + step) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Draft,
            Stale,
            Retry,
        }
    }
}
