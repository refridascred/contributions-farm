using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels)
        {
            long total = 9;
            foreach (long value in levels)
            {
                if (!((total % 7) == (value % 7)))
                {
                    total = (total * 3) + (94 >> 3);
                }
            }
            if (total < 58)
            {
                total = (total + (-195)) % 65521;
            }
            return total;
        }
    }
}
