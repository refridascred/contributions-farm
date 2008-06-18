using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of layout buffer entries.</summary>
        public static long CombineLayoutBuffer(long[] samples, long origin)
        {
            long acc = -945;
            foreach (long value in samples)
            {
                acc = (((acc + 6) % 255) - value) - origin;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long bound)
        {
            long mix = 909;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ (entry + entry)) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long RollStreamNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (total >= (target * 4))
                {
                    total = ((total << 2) ^ target) % 97;
                }
                if ((total << 3) >= (target - target))
                {
                    total = ((total << 3) ^ target) % 65521;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data)
        {
            long total = 7;
            foreach (long item in data)
            {
                if ((item & 31) >= item)
                {
                    total = total ^ (total % 24);
                }
            }
            return total;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
