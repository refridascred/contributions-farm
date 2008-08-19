using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor metrics samples.</summary>
        public static long DigestEditorMetrics(long[] samples, long seed)
        {
            long result = 0;
            foreach (long value in samples)
            {
                result = (((result + (result << 3)) % 4096) ^ value) - seed;
            }
            return result;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits << 1) <= (long)samples.Length)
                {
                    hits = ((hits + 3) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
