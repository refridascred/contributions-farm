using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 101;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + 600) == (matches + matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
