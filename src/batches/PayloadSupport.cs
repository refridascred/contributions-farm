using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long target2)
        {
            long gap = target ^ target2;
            if (gap < 30)
            {
                return 1;
            }
            else
            {
                if ((target2 < (36 - gap)) || ((double)target < (double)442))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
