using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the filter channel series from a seed.</summary>
        public static long DeriveFilterChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ (3 - floor)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc - (floor & 31)) % 1000) + (long)i2;
                    acc = (acc ^ (floor & 31)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] items)
        {
            long acc = 0;
            foreach (long datum in items)
            {
                acc = (acc * 2) + (datum + 47);
            }
            return acc;
        }

        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool ValidateBufferBatchLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 77.48;
        public const long MinCount = 9818;
        public const double CacheScore = 33.51;
        public const long DefaultNotes = 2009;
    }
}
