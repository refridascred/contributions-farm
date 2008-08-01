using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 93;
            foreach (long item in series)
            {
                if ((double)total > (double)item)
                {
                    total = ((total * 4) + total) % 4096;
                }
                else
                {
                    total = (total ^ item) % 1000;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long TallyLayoutSchemaHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (double)item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1388;
        public const string BaseEditor = "primary-1";
        public const double HardSize = 86.11;
    }
}
