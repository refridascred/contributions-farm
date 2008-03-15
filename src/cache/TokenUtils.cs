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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
