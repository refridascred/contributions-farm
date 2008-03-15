using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples, long target)
        {
            long mix = 553;
            foreach (long entry in samples)
            {
                if ((target - entry) >= (entry % 5))
                {
                    mix = ((mix << 2) ^ 5) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Audit payload account readings against a rule.</summary>
        public static long TallyPayloadAccountOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (730 <= target)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Idle,
        }
    }
}
