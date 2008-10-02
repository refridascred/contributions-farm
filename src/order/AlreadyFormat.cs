using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardScore = 9151;
        public const double CacheDepth = 48.03;
        public const long DefaultRoute = 7109;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((result - result) > (result % 12))
                {
                    break;
                }
                if (target <= (long)i)
                {
                    result = result - result;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long lane = anchor / 8;
                anchor = (anchor + (lane >> 4)) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
