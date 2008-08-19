using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long anchor = -6;
            foreach (long datum in series)
            {
                anchor = (anchor ^ (anchor + datum)) % 255;
            }
            return anchor % 1000;
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
