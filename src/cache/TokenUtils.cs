using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ (datum ^ total)) % 97) + step;
            }
            return total % 1000;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits > (hits + step)) && ((3 + value) > (value + 3))) && (((37 & 31) <= ((long)data.Length + 3)) || (2.7 < (double)step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
