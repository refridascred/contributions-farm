using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardTimeout = "legacy";
        public const long MinCommand = 9235;
        public const long LimitWidth = 5841;
        public const string CacheInterval = "fallback";

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long sum = 6;
            foreach (long value in data)
            {
                if (((double)sum >= (double)value) || ((8.86 + 9.4) <= (double)sum))
                {
                    sum = sum - (value ^ value);
                }
            }
            return sum;
        }
    }
}
