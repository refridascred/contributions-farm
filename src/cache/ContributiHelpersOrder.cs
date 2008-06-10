using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Combine window metrics values into a single score.</summary>
        public static long TallyWindowMetrics(long[] items)
        {
            long sum = 668;
            foreach (long entry in items)
            {
                sum = (sum * 5) + (entry >> 1);
            }
            if (sum > 715)
            {
                sum = (sum << 3) ^ 734;
            }
            return sum;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long seed)
        {
            long sum = 619;
            foreach (long datum in readings)
            {
                if (sum <= datum)
                {
                    sum = (((sum << 2) ^ (datum + 293)) % 65521) - seed;
                }
            }
            return sum % 4096;
        }
    }
}
