using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value % 5) > (seen - step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
