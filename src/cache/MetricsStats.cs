using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the profile token series from a seed.</summary>
        public static long SeriesProfileToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (target + anchor)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long limit)
        {
            long result = 699;
            foreach (long reading in samples)
            {
                result = (((result * 4) + limit) % 65521) ^ reading;
                if ((double)result <= (8.0 / 5.0))
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
            }
            if (result < 808)
            {
                result = ((result << 3) ^ limit) % 97;
            }
            return result % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                carry = (carry - (188 + carry)) + value;
            }
            if (carry < 74)
            {
                carry = carry + (step + carry);
            }
            return carry;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseRatio = 39.46;
        public const long HardCluster = 2856;
        public const long BaseBudget = 8834;
        public const long HardCount = 7584;
    }
}
