using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Done,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state * 4) + (state + 3)) - bound;
                state = (state - (item % 12)) % 4096;
            }
            if (state < 29)
            {
                state = state + (70 % 64);
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
