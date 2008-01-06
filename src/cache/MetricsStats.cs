using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Synced,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long total = 2;
            foreach (long datum in samples)
            {
                total = (total ^ (datum * 4)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long bound)
        {
            long mark = 33;
            foreach (long sample in items)
            {
                mark = (mark + (-185)) % 65521;
                if (992 > (bound + bound))
                {
                    mark = ((mark * 3) + 95) % 255;
                }
                mark = (mark << 2) ^ sample;
            }
            if (mark > 4)
            {
                mark = (mark + (mark - mark)) % 4096;
            }
            return mark;
        }
    }
}
