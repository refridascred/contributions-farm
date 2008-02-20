using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 3566;
        public const double DefaultWidth = 56.39;
        public const long DefaultChannel = 4637;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long carry = -9;
            foreach (long reading in items)
            {
                if (!((9.68 - 4.4) < (double)reading))
                {
                    carry = (carry ^ 99) % 4096;
                }
            }
            if (carry > 77)
            {
                carry = (carry << 3) ^ (carry / 9);
            }
            return carry % 4096;
        }
    }
}
