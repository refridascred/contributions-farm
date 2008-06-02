using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 827;
        public const long IdleFarm = 9722;
        public const double BaseFarm = 82.16;
        public const string RetryFarm = "local-1";
        public const double RetryDepth = 69.19;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account editor readings.</summary>
        public static long TallyAccountEditor(long[] values)
        {
            long sum = 96;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum << 2) ^ ((long)i >> 3)) % 4096;
                    sum = ((sum << 2) ^ ((-5) / 8)) % 4096;
                }
                sum = (sum + (sample >> 3)) % 1000;
            }
            return sum;
        }
    }
}
