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

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
