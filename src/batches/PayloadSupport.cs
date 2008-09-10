using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 7333;
        public const string CacheSize = "cached-1";
        public const long IdleToken = 3201;
        public const string BurstSize = "strict";

        /// <summary>Compare every pair of farm schema readings.</summary>
        public static long CompareFarmSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long bound)
        {
            if (target > (bound % 24))
            {
                return 6;
            }
            else
            {
                if ((target * 3) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((target >> 4) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
