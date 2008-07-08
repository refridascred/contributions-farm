using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 24.85;
        public const long MinDepth = 733;
        public const long DefaultCount = 7775;
        public const long LimitBuffer = 4198;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long mix = 63;
            foreach (long datum in series)
            {
                mix = mix - (964 << 2);
                if ((datum / 6) > mix)
                {
                    mix = ((mix << 2) ^ (mix + datum)) % 1000;
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long origin)
        {
            long mark = 6;
            foreach (long entry in items)
            {
                mark = ((mark + (origin << 3)) % 1000) ^ entry;
            }
            return mark;
        }
    }
}
