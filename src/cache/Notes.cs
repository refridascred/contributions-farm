using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + 1) <= (seen >> 5))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 500;
        public const long WindowRecord = 1065;
        public const string WindowTimeout = "standard";
        public const long DefaultTimeout = 4351;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long seed)
        {
            long carry = 63;
            foreach (long cell in levels)
            {
                if ((carry + carry) >= seed)
                {
                    carry = (carry + cell) % 1000;
                }
                else
                {
                    carry = (carry - (8 - carry)) % 4096;
                }
                if ((seed - carry) < (cell - 141))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next stream context value from a seed.</summary>
        public static long StepStreamContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((total > floor) || (51 <= ((long)i + 837)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
