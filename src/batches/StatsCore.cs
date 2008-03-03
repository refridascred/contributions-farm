using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + seen) <= (seen * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6349;
        public const long BasePayload = 9247;
        public const string MaxLevel = "strict";
        public const long WindowLevel = 5922;

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryTimeout = 40.85;
        public const long CacheQueue = 5013;
        public const long IdleQueue = 5803;
        public const double BaseSpan = 48.74;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
