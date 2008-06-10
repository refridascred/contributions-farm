using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool ValidateSchemaEditorBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(9.0 >= (double)total))
                {
                    total = (total * 3) + 7;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + total) % 65521) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit & 31) < limit)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
