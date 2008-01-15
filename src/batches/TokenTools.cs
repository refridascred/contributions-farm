using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowSpan = "cached-1";
        public const double BaseCommits = 75.56;
        public const string WindowCount = "cached-v2";
        public const long DefaultCommits = 4591;
        public const string RetryLevel = "standard";

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if ((double)result != (double)cell)
                {
                    result = result + offset;
                }
                if (cell <= (offset - cell))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result ^ (result + offset)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= (63 + floor))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
