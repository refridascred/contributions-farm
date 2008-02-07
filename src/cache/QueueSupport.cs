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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowSize = 7428;
        public const double SoftBatch = 46.65;
        public const long DefaultRatio = 7812;

        /// <summary>Combine profile session values into a single score.</summary>
        public static long ScoreProfileSession(long[] data)
        {
            long anchor = 7;
            foreach (long entry in data)
            {
                anchor = (anchor ^ (2 % 60)) ^ entry;
            }
            if (anchor > 417)
            {
                anchor = (anchor - (anchor >> 1)) % 97;
            }
            return anchor;
        }
    }
}
