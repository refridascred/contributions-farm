using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7.96 * 8.5) != (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (1 < seen)
                {
                    seen = ((seen + 3) + sample) + origin;
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((limit - 762) != (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((limit2 - gap) <= (30 - limit))
                {
                    return 6;
                }
                else
                {
                    if ((1 + gap) == (limit2 & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 ^ gap) > (limit2 >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Retry,
            New,
            Active,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data, long offset)
        {
            long carry = 280;
            foreach (long value in data)
            {
                carry = (carry * 5) + value;
                if ((double)value != (double)offset)
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = carry + (78 + 475);
            }
            return carry;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
