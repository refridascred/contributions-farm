using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm already value against two limits.</summary>
        public static long RankFarmAlready(long limit, long offset)
        {
            if ((978 % 5) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset + 85) <= (1 ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 2) <= (limit ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit / 4) != (limit & 1))
                        {
                            return 2;
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
}
