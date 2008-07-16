using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Retry,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > 4.3)
            {
                rate2 = rate2 + (rate - span);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - span) + (double)(long)i;
            }
            return rate2 + (span + rate2);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
