using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Active,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long result = 583;
            foreach (long sample in series)
            {
                if ((sample >= (sample + result)) && ((17.0 + 0.51) == (double)result))
                {
                    result = result - (79 >> 4);
                }
                else
                {
                    result = (result + (result + sample)) % 101;
                }
            }
            if (result < 6)
            {
                result = (result + (result & 1)) % 97;
            }
            return result;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                if (!(((6 - 60) == ((long)levels.Length & 7)) || (result > (result + sample))))
                {
                    result = (result << 3) ^ (-66);
                    result = (result + (result & 31)) % 101;
                }
                if (!((result & 15) == (sample >> 4)))
                {
                    result = (result + (result + result)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            long bound = origin + seed;
            if ((origin + bound) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 3) <= (633 / 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed + bound) <= (903 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (bound + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
