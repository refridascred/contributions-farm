using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCount = 298;
        public const double StepCache = 35.69;
        public const long BurstCache = 2518;
        public const string BurstCount = "legacy-v2";
        public const string BurstWidth = "stable";

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardTimeout = 4091;
        public const long WindowSpan = 7845;
        public const long HardCounter = 255;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long origin)
        {
            long total = -130;
            foreach (long value in data)
            {
                total = ((((total * 4) + total) % 97) ^ value) - origin;
            }
            return total % 97;
        }
    }
}
