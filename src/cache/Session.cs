using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 6257;
        public const long DefaultStream = 8119;
        public const string SoftSpan = "strict-edge";
        public const long BaseStream = 3331;
        public const string MaxStream = "primary-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "standard-1";
        public const long BurstContributi = 6394;
        public const long BurstInterval = 4652;
        public const string DefaultContributi = "cached-1";
        public const double MaxCount = 0.92;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark << 3) ^ step) % 65521;
                mark = (mark << 3) ^ (long)i;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
