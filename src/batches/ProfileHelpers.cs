using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "stable-v2";
        public const long RetryTimeout = 4153;
        public const double IdleChecks = 79.87;
        public const long MinSize = 1746;
        public const long CacheScore = 1161;

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ result) ^ datum) - offset;
            }
            if (result < (-5))
            {
                result = (result ^ (1 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "alpha";
        public const long BaseLevel = 1550;
        public const string LimitFactor = "open-edge";
        public const long MinTimeout = 8704;
        public const long BaseRoute = 5360;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 97) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
