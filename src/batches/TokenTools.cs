using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metrics batches values into a single score.</summary>
        public static long DigestMetricsBatches(long[] series, long offset)
        {
            long anchor = 128;
            foreach (long cell in series)
            {
                if ((anchor + offset) > offset)
                {
                    anchor = ((anchor ^ offset) % 4096) ^ cell;
                }
                else
                {
                    anchor = (anchor + (anchor << 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if ((origin + 9) < (305 ^ target))
            {
                return 3;
            }
            else
            {
                if (target <= origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
