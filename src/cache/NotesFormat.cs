using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowLevel = 9453;
        public const long CacheFormat = 7046;
        public const double BatchFormat = 0.11;

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series, long target)
        {
            long mark = 816;
            foreach (long value in series)
            {
                mark = (mark + (value % 24)) % 101;
                if ((485 / 8) > (mark - value))
                {
                    mark = (mark << 2) ^ (mark >> 3);
                }
                if (((value << 1) >= mark) && (mark <= (target - value)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowTimeout = "stable-edge";
        public const string BaseSize = "standard-edge";
        public const string SoftSize = "latest-edge";
    }
}
