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

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2963;
        public const long BatchInterval = 1012;
        public const string CacheContext = "latest-v2";
        public const double DefaultRatio = 80.66;

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
