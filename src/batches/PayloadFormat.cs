using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long limit)
        {
            long acc = 575;
            foreach (long entry in series)
            {
                if ((limit << 1) > ((long)series.Length >> 1))
                {
                    acc = acc - (9 - limit);
                }
                else
                {
                    acc = ((acc << 3) ^ (entry + acc)) % 4096;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 2) ^ (acc * 5)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels)
        {
            long total = 1;
            foreach (long reading in levels)
            {
                total = (total << 2) ^ (total - reading);
            }
            return total % 4096;
        }
    }
}
