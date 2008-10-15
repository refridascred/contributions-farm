using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 95;
            foreach (long value in levels)
            {
                result = (result << 3) ^ ((-8) ^ value);
            }
            if (result > 46)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Ready,
            Failed,
            Pending,
        }
    }
}
