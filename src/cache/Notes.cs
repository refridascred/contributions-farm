using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSpan = 94.81;
        public const double MaxSize = 96.84;
        public const long DefaultNotes = 6449;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 155;
            foreach (long value in samples)
            {
                anchor = ((anchor - (55 - (-4))) % 255) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleSize = 4.07;
        public const double DefaultCache = 68.77;
        public const long BatchCache = 3427;
        public const long LimitScore = 3847;
    }
}
