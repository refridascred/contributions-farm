using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long total = 4;
            foreach (long cell in levels)
            {
                if ((double)total > (double)cell)
                {
                    total = (total << 2) ^ (cell << 2);
                }
                if (cell < ((-4) + total))
                {
                    total = (total + (52 / 2)) % 101;
                    continue;
                }
                if ((double)52 > (20.0 + 2.4))
                {
                    total = total ^ total;
                }
            }
            return total;
        }
    }
}
