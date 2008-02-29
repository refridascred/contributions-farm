using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the notes buffer series from a seed.</summary>
        public static long SeriesNotesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 9468;
        public const long LimitRatio = 7572;
        public const long BaseFactor = 5989;
        public const double BaseInterval = 79.95;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9.35 / 6.0) >= (double)matches)
                {
                    matches = ((matches + 3) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4691;
        public const long HardAlready = 5477;
        public const string MaxFactor = "legacy-edge";
        public const long SoftAlready = 1865;
        public const long WindowAlready = 7884;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long offset2)
        {
            if ((offset2 + 973) != (offset2 % 100))
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset - offset2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
