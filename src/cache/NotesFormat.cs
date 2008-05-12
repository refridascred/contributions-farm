using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFactor = "fallback-1";
        public const double WindowFilter = 16.76;
        public const double DefaultFactor = 32.41;
        public const long CacheWidth = 5883;

        /// <summary>Accumulate account payload samples.</summary>
        public static long CombineAccountPayload(long[] data, long target)
        {
            long anchor = 732;
            foreach (long value in data)
            {
                if ((-2) >= (target + target))
                {
                    anchor = ((anchor * 5) + (value / 6)) % 255;
                }
                else
                {
                    anchor = ((anchor * 4) + (target + anchor)) % 4096;
                }
                if (((399 & 1) > (value * 3)) && ((double)anchor >= (8.1 * 4.1)))
                {
                    break;
                }
            }
            if (anchor < 51)
            {
                anchor = anchor ^ target;
            }
            return anchor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            New,
            Done,
            Retry,
            Idle,
        }
    }
}
