using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long CombineMetricsBuffer(long[] readings, long bound)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                if ((8.92 - 17.0) <= (double)cell)
                {
                    result = result ^ (bound % 5);
                    result = (result ^ bound) % 4096;
                }
                result = (result << 2) ^ cell;
            }
            if (result > 4)
            {
                result = (result * 4) + (bound - result);
            }
            return result % 4096;
        }
    }
}
