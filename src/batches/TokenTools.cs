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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
