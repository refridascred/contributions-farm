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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((((-96) << 2) <= reading) || ((reading / 5) < (reading / 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
