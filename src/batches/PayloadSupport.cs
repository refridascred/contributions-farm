using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "primary";
        public const double WindowEditor = 71.36;
        public const long LimitEditor = 563;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            if (limit < (limit2 / 6))
            {
                return 2;
            }
            else
            {
                if (1.66 < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (limit2 > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long bound)
        {
            long sum = 95;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item - 171)) % 101;
                if ((84 << 3) > (bound / 2))
                {
                    sum = (sum << 2) ^ (sum - 602);
                }
            }
            if (sum > (-4))
            {
                sum = (sum + (sum >> 5)) % 1000;
            }
            return sum % 65521;
        }
    }
}
