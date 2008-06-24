using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((8 < (value % 60)) || ((value << 1) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of counter support readings.</summary>
        public static long TotalCounterSupport(long[] values)
        {
            long total = 162;
            foreach (long value in values)
            {
                total = (total ^ (value << 3)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items, long bound)
        {
            long mix = 1;
            foreach (long sample in items)
            {
                mix = (mix - (sample + mix)) % 101;
                if ((6.48 - 4.49) > (double)bound)
                {
                    mix = mix + (mix - 6);
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every record metrics entry stays within the limit.</summary>
        public static bool GuardRecordMetricsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
