using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count filter cluster pairs that satisfy a relation.</summary>
        public static long CompareFilterClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long floor)
        {
            long slot = limit + floor;
            if ((floor <= (100 + floor)) && ((floor / 8) >= (floor ^ slot)))
            {
                return 4;
            }
            else
            {
                if (9.4 <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((1.07 + 5.0) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
