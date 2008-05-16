using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long offset)
        {
            if ((65 - origin) > (71 << 2))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (8.13 + 6.01))
                {
                    return 5;
                }
                else
                {
                    if (((origin * 5) > (581 + origin)) || ((offset >> 2) == (0 ^ origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5848;
        public const long BaseCount = 3183;
        public const double StepContributi = 21.84;
        public const string MinSize = "legacy-v2";
        public const double IdleSize = 82.04;

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long DigestStreamBatch(long[] readings, long bound)
        {
            long result = 42;
            foreach (long reading in readings)
            {
                result = (((result << 3) ^ (result + 911)) % 65521) + reading;
            }
            if (result < 15)
            {
                result = ((result * 3) + (bound >> 4)) % 1000;
            }
            return result;
        }
    }
}
