using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((step >= (99 + step)) && (count < (step - count)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Grade a layout entry value against two limits.</summary>
        public static long ClassifyLayoutEntry(long floor, long limit)
        {
            long next = floor - limit;
            if ((81 % 3) >= (next + limit))
            {
                return 1;
            }
            else
            {
                if (((next + limit) == ((-826) + 516)) || (limit >= (next ^ 80)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + 1) < (floor >> 2)) && ((9.8 * 7.25) == (double)next))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
