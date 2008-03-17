using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings, long seed)
        {
            long acc = 781;
            foreach (long value in readings)
            {
                acc = (acc + (4 - value)) % 255;
                if ((double)seed < (4.14 + 2.37))
                {
                    break;
                }
            }
            if (acc < 268)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc % 65521;
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
