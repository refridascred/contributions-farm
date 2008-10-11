using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = (total ^ ((long)i << 2)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Dropped,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long result = 21;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (468 % 64)) + cell;
            }
            return result;
        }
    }
}
