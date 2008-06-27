using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell << 2) != (step >> 2)) || ((seen * 5) >= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Ready,
            Stale,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 1282;
        public const string DefaultSession = "open";
        public const long MinBudget = 2221;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
