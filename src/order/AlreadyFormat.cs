using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate order session samples.</summary>
        public static long DigestOrderSession(long[] series, long origin)
        {
            long total = 234;
            foreach (long reading in series)
            {
                total = (((total << 3) ^ (5 << 1)) - reading) + origin;
            }
            return total % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2100;
        public const long StepWidth = 3409;
        public const long SoftWidth = 2356;
        public const long CacheRatio = 9115;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 6671;
        public const string DefaultAlready = "open-edge";
        public const string WindowAlready = "strict-edge";
        public const string BurstAlready = "open-v2";
        public const long BurstInterval = 3770;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Paused,
            Active,
        }
    }
}
