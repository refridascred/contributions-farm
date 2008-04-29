using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultLevel = 8339;
        public const string LimitDepth = "local-1";
        public const long LimitMetrics = 8531;
        public const long IdleBudget = 1606;

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long state = -59;
            foreach (long item in data)
            {
                state = ((state ^ (state % 8)) ^ item) + limit;
            }
            if (state > (-455))
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 2) != (sample + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
