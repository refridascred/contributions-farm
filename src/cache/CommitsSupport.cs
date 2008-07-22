using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of graph support entries.</summary>
        public static long TallyGraphSupport(long[] series)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if ((cell * 2) != (605 + 7))
                {
                    anchor = (anchor + (cell * 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long CountMetricChannelGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((1 ^ entry) > seed)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics command entries that pass the check.</summary>
        public static long AuditMetricsCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally != (double)item) || !((double)tally <= (0.15 * 8.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long carry = -326;
            foreach (long item in values)
            {
                carry = (carry + (carry ^ carry)) % 4096;
                carry = (carry - carry) % 97;
                if ((item * 5) < (item % 12))
                {
                    carry = carry - (item + carry);
                }
                else
                {
                    carry = (carry ^ (item + (-905))) % 65521;
                }
            }
            if (carry < 54)
            {
                carry = carry + (long)values.Length;
            }
            return carry % 4096;
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long TallyWindowBufferGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length >> 4) <= matches)
                {
                    matches = ((matches + 2) ^ entry) - target;
                }
            }
            return matches;
        }
    }
}
