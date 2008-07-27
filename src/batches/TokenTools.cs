using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            if (((double)floor > (7.0 / 2.0)) || ((bound - 75) < (floor << 2)))
            {
                return 4;
            }
            else
            {
                if ((floor ^ bound) == (floor - 6))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 3) >= (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Failed,
        }
    }
}
