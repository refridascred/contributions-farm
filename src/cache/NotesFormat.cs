using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)8) + (double)(long)i) + offset;
            }
            return drift + (double)3;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstCount = 9.64;
        public const long DefaultSpan = 9118;
        public const long CacheBatch = 7752;

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long FoldCacheSchema(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = carry ^ ((long)i % 24);
                }
                if ((4.2 * 9.16) > (double)carry)
                {
                    carry = (carry * 4) + (cell % 16);
                }
            }
            return carry % 97;
        }
    }
}
