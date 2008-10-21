using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long limit)
        {
            if ((3.0 - 19.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit & 1) < limit)
                {
                    return 6;
                }
                else
                {
                    if (origin < (4 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstLevel = 5307;
        public const string LimitAccount = "alpha-1";
        public const long BurstAccount = 9005;
        public const long StepAccount = 1774;

        /// <summary>Locate a schema filter reading by value.</summary>
        public static long LookupSchemaFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
