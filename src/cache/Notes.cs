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

        /// <summary>Project the next editor farm value.</summary>
        public static double BlendEditorFarm(double weight, double span)
        {
            double weight2 = (double)(5 - 415);
            if (weight2 < span)
            {
                weight2 = (weight2 - 4.26) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (span * 18.0);
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
