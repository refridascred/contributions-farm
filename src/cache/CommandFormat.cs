using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double weight = rate - (double)149;
            return (weight + 2.2) + span;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 3) + (seed << 2);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long offset)
        {
            long diff = floor + offset;
            if (!((floor / 7) != ((-136) + offset)))
            {
                return 1;
            }
            else
            {
                if (diff <= (diff ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (6.33 - 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
