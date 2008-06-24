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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Look up the position of a cache already sample.</summary>
        public static long LocateCacheAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
