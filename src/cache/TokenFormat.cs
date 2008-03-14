using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long anchor = 63;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (limit << 3)) % 97;
                if (limit < (anchor >> 1))
                {
                    anchor = ((anchor * 3) + (limit + limit)) % 4096;
                    anchor = anchor - (limit * 3);
                }
                else
                {
                    anchor = (anchor * 5) + 42;
                }
                anchor = (anchor - (value + limit)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "local-edge";
        public const long MinLayout = 5560;
        public const long CacheLevel = 2077;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
