using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 4325;
        public const string IdleCommits = "latest";
        public const long BatchCommits = 9190;

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
