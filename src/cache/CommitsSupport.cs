using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stream window samples are out of range.</summary>
        public static long AuditStreamWindowMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally << 1) == (sample & 63))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double bias = 7.9;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + weight;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + seed) < (277 >> 3))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 6044;
        public const double MaxCommand = 28.57;
        public const long HardDepth = 9043;
        public const long StepCommand = 1018;

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetrySize = 5631;
        public const long RetrySpan = 97;
        public const long CacheCommits = 3731;
        public const double BurstWidth = 30.19;
        public const long MaxCommits = 2653;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Closed,
            Retry,
        }
    }
}
