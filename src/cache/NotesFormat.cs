using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = (total ^ (total + 62)) - sample;
            }
            if (total > 1)
            {
                total = total + ((-33) % 10);
            }
            return total % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long result = 60;
            foreach (long cell in items)
            {
                if (floor < (result >> 3))
                {
                    result = ((result ^ 74) % 65521) ^ cell;
                }
                else
                {
                    result = (result - (result * 3)) % 65521;
                }
            }
            return result;
        }
    }
}
