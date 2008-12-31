using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = ((mark << 2) ^ sample) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long step)
        {
            if (step >= (step ^ offset))
            {
                return 6;
            }
            else
            {
                if ((58 <= (step / 4)) || ((double)step < 0.4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3299;
        public const double WindowRatio = 51.25;
        public const long WindowSize = 3244;
        public const long MinSpan = 6414;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((bound - reading) != (1 + 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 94.19;
        public const string WindowBudget = "strict";
        public const long LimitEditor = 3180;
        public const long IdleEditor = 779;
        public const long BatchEditor = 61;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Stale,
            Draft,
        }
    }
}
