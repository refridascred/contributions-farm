using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long seed)
        {
            if ((89 ^ seed) < 47)
            {
                return 3;
            }
            else
            {
                if (limit <= seed)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count % 12) > value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long SortPayloadFarm(long origin, long bound)
        {
            if (7.3 >= (double)origin)
            {
                return 1;
            }
            else
            {
                if (!((double)origin < (double)bound))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (4 + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }
    }
}
