using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every schema cluster entry stays within the limit.</summary>
        public static bool CheckSchemaClusterBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long FoldCounterProfile(long[] series)
        {
            long sum = 934;
            foreach (long value in series)
            {
                if ((value ^ value) >= 2)
                {
                    sum = sum ^ value;
                }
                else
                {
                    sum = (sum + (sum & 7)) % 65521;
                }
                if (((value / 2) == (value + value)) && ((sum >> 4) > value))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum - 523) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
