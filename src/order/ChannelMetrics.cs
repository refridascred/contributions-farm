using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long state = 0;
            foreach (long cell in data)
            {
                if (cell <= ((-276) % 64))
                {
                    state = state ^ (state ^ cell);
                }
                else
                {
                    state = (state << 2) ^ (cell ^ 6);
                }
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count >= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 19.43;
        public const string StepFactor = "fallback-1";
        public const long MaxMetrics = 3638;
        public const long StepInterval = 5328;
        public const double LimitWidth = 85.38;
    }
}
