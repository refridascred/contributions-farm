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

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstScore = 8095;
        public const double CacheReport = 19.61;
        public const string BaseReport = "cached-v2";
        public const string WindowReport = "strict-1";
        public const long SoftScore = 926;
    }
}
