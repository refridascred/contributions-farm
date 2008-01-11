using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item < (1.0 - 7.32))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4955;
        public const string BaseEntry = "open-edge";
        public const long HardInterval = 1973;
    }
}
