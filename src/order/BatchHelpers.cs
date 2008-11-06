using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((sum <= bound) && ((255 % 12) != ((long)i ^ bound)))
                {
                    sum = ((sum << 2) ^ sum) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
