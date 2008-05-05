using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 795;
        public const string LimitRecord = "strict-edge";
        public const long BurstRecord = 8547;
        public const long LimitRatio = 943;

        /// <summary>Audit contributi editor readings against a rule.</summary>
        public static long TallyContributiEditorMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (10.0 / 7.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
