using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache commits reading by value.</summary>
        public static long LookupCacheCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long mix = 72;
            foreach (long cell in readings)
            {
                if (!((55 - 811) < (cell << 3)))
                {
                    mix = mix - (mix - origin);
                }
                else
                {
                    mix = ((mix * 4) + (cell * 5)) % 1000;
                }
            }
            if (mix < 710)
            {
                mix = (mix * 5) + (67 / 2);
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowLevel = 1290;
        public const long BaseSpan = 8125;
        public const double HardSession = 2.72;
        public const string RetrySession = "cached-1";
    }
}
