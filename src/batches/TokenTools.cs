using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of channel entry readings.</summary>
        public static long WeighChannelEntry(long[] levels)
        {
            long sum = 254;
            foreach (long sample in levels)
            {
                if ((91 > sample) && ((545 / 9) < sum))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                    continue;
                }
                sum = sum + ((long)levels.Length - sum);
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (90 + sum);
            }
            return sum;
        }

        /// <summary>Count the queue profile entries that pass the check.</summary>
        public static long AuditQueueProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(90 > seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleLevel = 19.8;
        public const long BaseInterval = 5857;
        public const string BaseSpan = "cached-1";
        public const long MinContext = 2680;
        public const double StepContext = 75.44;
    }
}
