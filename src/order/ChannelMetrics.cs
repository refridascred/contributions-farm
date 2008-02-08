using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry + (step + 6)) % 1000) - (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = ((carry + (carry >> 1)) % 255) ^ (long)i3;
                }
                if ((step + carry) < (carry >> 3))
                {
                    carry = (carry * 5) + carry;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Retry,
            Idle,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 1.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
