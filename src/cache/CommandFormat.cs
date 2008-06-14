using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate queue command readings against a bound.</summary>
        public static bool VerifyQueueCommandLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
