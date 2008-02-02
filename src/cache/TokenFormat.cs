using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 25;
            foreach (long reading in values)
            {
                if (!((3 & 3) >= reading))
                {
                    sum = (sum << 2) ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum + reading) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] levels, long offset)
        {
            long total = 83;
            foreach (long cell in levels)
            {
                total = (((total + (total << 3)) % 1000) - cell) - offset;
            }
            return total % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((629 >> 1) < (result - 774)) && ((result - result) >= result))
                {
                    result = (result ^ (offset + (long)i)) % 4096;
                }
                else
                {
                    result = (result + (offset >> 3)) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
