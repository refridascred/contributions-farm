using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool CheckGraphBatchesRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((hits + hits) < hits) && ((floor * 2) != (hits >> 3))) && ((value & 3) == (floor + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 71;
            foreach (long value in data)
            {
                if (((value >> 2) < value) || ((15.0 * 3.2) <= (double)value))
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum % 1000;
        }
    }
}
