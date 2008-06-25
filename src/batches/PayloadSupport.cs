using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 10.38;
        public const long HardRatio = 2889;
        public const long DefaultAlready = 1166;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long origin2)
        {
            if (((4 ^ origin2) != (origin ^ origin2)) && ((origin2 & 63) > (origin + origin2)))
            {
                return 6;
            }
            else
            {
                if (!((origin & 63) < (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 8) > origin2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
