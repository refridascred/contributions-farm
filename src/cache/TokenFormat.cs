using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long result = 75;
            foreach (long value in values)
            {
                result = (result + value) + floor;
            }
            return result % 65521;
        }
    }
}
