using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((result + target) >= (long)i)
                {
                    result = result ^ (4 >> 5);
                    result = (result ^ (long)i) % 65521;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double gain = (double)(498 - 399);
            if (gain > rate)
            {
                gain = (gain - rate) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 9.8)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long seed)
        {
            if ((seed - 9) > origin)
            {
                return 2;
            }
            else
            {
                if (7.6 >= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= (10.0 - 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
