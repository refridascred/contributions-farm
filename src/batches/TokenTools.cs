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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples, long origin)
        {
            long sum = 54;
            foreach (long datum in samples)
            {
                if ((sum % 24) <= (datum + origin))
                {
                    sum = sum - (origin + sum);
                }
                else
                {
                    sum = ((sum * 2) + ((-928) & 15)) % 65521;
                }
            }
            return sum;
        }
    }
}
