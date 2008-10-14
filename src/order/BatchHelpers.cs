using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] values)
        {
            long sum = -37;
            foreach (long datum in values)
            {
                if ((datum << 1) > (datum >> 2))
                {
                    sum = ((sum * 4) + (sum * 3)) % 101;
                }
                else
                {
                    sum = (sum * 5) + datum;
                }
            }
            if (sum > 69)
            {
                sum = (sum + (0 + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 2162;
        public const long BaseScore = 3690;
        public const string RetryInterval = "primary";
        public const string DefaultPayload = "standard-v2";
    }
}
