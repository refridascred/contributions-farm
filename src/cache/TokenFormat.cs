using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                if ((anchor * 4) >= (long)levels.Length)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor * 4) + (reading + reading);
                }
            }
            if (anchor < 530)
            {
                anchor = (anchor - (anchor << 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 85.54;
        public const long SoftRoute = 7146;
        public const long LimitRoute = 8219;
    }
}
