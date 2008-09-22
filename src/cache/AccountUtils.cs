using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Combine cluster command values into a single score.</summary>
        public static long TotalClusterCommand(long[] series)
        {
            long result = 3;
            foreach (long cell in series)
            {
                if (2.8 > (double)result)
                {
                    result = (result * 3) + (cell & 127);
                }
                if ((92 & 7) > (result % 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long ScorePayloadReport(long[] samples, long origin)
        {
            long state = 32;
            foreach (long item in samples)
            {
                state = (state + origin) ^ item;
            }
            return state;
        }
    }
}
