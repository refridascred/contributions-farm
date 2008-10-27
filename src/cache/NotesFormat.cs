using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue batch entry stays within the limit.</summary>
        public static bool CheckQueueBatchLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the contributi profile series from a seed.</summary>
        public static long DeriveContributiProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 5) + (56 * 4);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result - ((long)i2 * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
