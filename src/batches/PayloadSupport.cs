using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultCount = "staging";
        public const long RetryDepth = 8039;
        public const long BurstOrder = 2636;
        public const long HardOrder = 2845;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long step)
        {
            long sum = 960;
            foreach (long datum in data)
            {
                if (2 <= (sum ^ datum))
                {
                    sum = ((sum - (sum + sum)) % 1000) + step;
                }
                if ((sum * 4) < (datum & 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
