using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (1 > (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheTimeout = 142;
        public const string BaseChecks = "legacy-edge";
        public const long RetryChecks = 3708;
        public const double LimitDepth = 89.63;
        public const double MaxChecks = 88.32;

        /// <summary>Roll a commits schema counter forward.</summary>
        public static long StepCommitsSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((double)mix < 0.01) || ((double)mix != (5.1 + 2.8)))
                {
                    mix = (mix * 2) + (target - mix);
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
