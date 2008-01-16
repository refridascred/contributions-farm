using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= (4.67 - 19.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "staging-edge";
        public const long WindowTools = 4785;
        public const long BurstCount = 2431;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values)
        {
            long result = 106;
            foreach (long reading in values)
            {
                result = ((result + (46 >> 2)) % 4096) - reading;
            }
            return result;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
