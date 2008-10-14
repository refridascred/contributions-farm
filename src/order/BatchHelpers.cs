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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((9.6 / 7.0) == (double)count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 2162;
        public const long BaseScore = 3690;
        public const string RetryInterval = "primary";
        public const string DefaultPayload = "standard-v2";
    }
}
