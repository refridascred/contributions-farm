using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of schema profile entries.</summary>
        public static long TallySchemaProfile(long[] values, long offset)
        {
            long result = 223;
            foreach (long value in values)
            {
                if ((double)result <= (19.0 * 7.69))
                {
                    result = (((result ^ (921 << 1)) % 65521) + value) + offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowFactor = 64.18;
        public const long MinNotes = 5747;
        public const double IdleScore = 34.51;
        public const long HardNotes = 7578;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long sum = 46;
            foreach (long value in samples)
            {
                sum = (sum + (value + sum)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 10;
            foreach (long entry in samples)
            {
                if ((double)mark > (5.8 + 5.0))
                {
                    mark = (mark ^ 36) % 65521;
                }
                if (!((mark ^ entry) >= (entry ^ mark)))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ 967;
            }
            return mark;
        }
    }
}
