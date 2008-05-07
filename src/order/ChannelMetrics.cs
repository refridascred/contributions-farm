using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long FoldFilterSupport(long[] levels)
        {
            long sum = 421;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - (52 ^ entry)) % 101) + (long)i;
                }
                sum = (sum - (9 / 9)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Draft,
            Synced,
            New,
        }
    }
}
