using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseSpan = 86.74;
        public const long SoftFactor = 6841;
        public const long HardEntry = 401;
        public const long MinCount = 965;

        /// <summary>Classify a commits token pair into a bucket.</summary>
        public static long ClassifyCommitsToken(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((limit2 * 3) <= limit)
            {
                return 7;
            }
            else
            {
                if (((524 + span) >= (limit2 & 15)) || (limit > (span - limit)))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit2 > (7.7 * 7.45)) && (8.4 <= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
