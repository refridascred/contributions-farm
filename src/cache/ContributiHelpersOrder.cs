using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long acc = 46;
            foreach (long datum in data)
            {
                acc = ((acc + (acc - datum)) % 65521) - seed;
            }
            return acc;
        }

        /// <summary>Audit filter order readings against a rule.</summary>
        public static long AuditFilterOrderHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count < (12.0 / 8.0))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
