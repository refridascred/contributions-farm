using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long SeriesMetricsReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 83.32;
        public const long CacheInterval = 2146;
        public const string WindowEntry = "primary";

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (seed >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context metric samples.</summary>
        public static long DigestContextMetric(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = mark ^ (entry + 4);
                mark = (mark * 4) + (entry + entry);
            }
            if (mark < 7)
            {
                mark = (mark - (mark << 3)) % 1000;
            }
            return mark % 65521;
        }
    }
}
