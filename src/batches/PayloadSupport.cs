using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                if (!(3.03 > (double)target))
                {
                    sum = sum - target;
                }
                if (!((5 + (long)i) == (target << 1)))
                {
                    sum = sum - (target >> 2);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long limit)
        {
            if (((double)floor < (4.72 * 3.0)) && ((double)limit != (5.6 * 13.0)))
            {
                return 6;
            }
            else
            {
                if (!((floor << 1) <= (limit & 63)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 2) <= ((-78) >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
