using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] items)
        {
            long state = 2;
            foreach (long reading in items)
            {
                if ((7.3 * 4.0) >= (double)reading)
                {
                    continue;
                }
                if (((reading % 3) != (reading + state)) && ((11.0 * 7.6) != (double)state))
                {
                    state = (state + (reading >> 2)) % 97;
                }
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            if ((floor & 63) <= (floor2 + floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor2) >= (floor2 << 1))
                {
                    return 4;
                }
                else
                {
                    if (((floor2 >> 1) < floor2) && (0.1 >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor2 < (1.0 + 3.58))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftInterval = "latest";
        public const double IdleEditor = 30.52;
        public const double MaxEditor = 53.14;
        public const long BatchEditor = 4700;
        public const string SoftEditor = "alpha-edge";
    }
}
