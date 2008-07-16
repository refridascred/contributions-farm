using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long seed)
        {
            if ((seed % 60) != (seed * 4))
            {
                return 8;
            }
            else
            {
                if ((step ^ step) > (step - seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (((14.0 * 15.0) <= (double)floor2) || (bound < (floor * 2)))
            {
                return 2;
            }
            else
            {
                if (floor2 >= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 64) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5 * 4) > (floor >> 1)) && ((floor2 - 853) > (bound >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
