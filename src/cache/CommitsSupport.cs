using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long floor)
        {
            if ((8 - floor) >= (target - 519))
            {
                return 7;
            }
            else
            {
                if ((target % 3) < (4 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (double)2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count == (double)0)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long origin, long origin2)
        {
            long lane = origin + origin2;
            if (1 <= origin2)
            {
                return 2;
            }
            else
            {
                if ((lane * 5) != (origin2 >> 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "alpha-1";
        public const long MaxGraph = 8569;
        public const string HardGraph = "strict-edge";
        public const long MinBudget = 9897;
    }
}
