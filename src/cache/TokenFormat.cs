using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long limit)
        {
            if ((seed <= (seed - seed)) && ((seed % 60) >= limit))
            {
                return 7;
            }
            else
            {
                if (((double)seed <= (7.28 - 1.14)) || ((1.0 * 1.04) != (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
