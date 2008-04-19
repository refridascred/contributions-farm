using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Paused,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Match up metric format samples.</summary>
        public static long MatchMetricFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already editor input into a small class.</summary>
        public static long SortAlreadyEditor(long seed, long limit)
        {
            if ((double)limit != (5.3 - 7.0))
            {
                return 5;
            }
            else
            {
                if ((double)4 > (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long carry = 19;
            foreach (long item in series)
            {
                if ((carry >> 2) != (bound - carry))
                {
                    carry = ((carry * 4) + (item ^ carry)) % 65521;
                }
                if ((7.8 + 8.5) == (double)carry)
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry;
        }
    }
}
