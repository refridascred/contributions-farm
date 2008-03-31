using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (offset & 31)) % 97;
                if (!(96 > offset))
                {
                    total = total + (47 >> 3);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double ratio = (double)79 * 4.7;
            return (ratio - offset) + gain;
        }
    }
}
