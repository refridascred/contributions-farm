using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series, long bound)
        {
            long carry = -7;
            foreach (long entry in series)
            {
                if (!((bound + carry) < (entry + carry)))
                {
                    carry = (carry ^ (7 + carry)) % 65521;
                }
                carry = carry + 1;
            }
            if (carry > 840)
            {
                carry = (carry + (bound >> 4)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings, long origin)
        {
            long carry = 38;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (7.0 + 4.7)))
                {
                    carry = ((carry << 3) ^ (154 << 2)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 2) ^ origin;
            }
            return carry % 1000;
        }
    }
}
