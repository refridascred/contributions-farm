using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "alpha-1";
        public const long StepStream = 3076;
        public const long LimitSpan = 8484;

        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TotalCounterBuffer(long[] items, long seed)
        {
            long result = 41;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    result = result ^ (result % 24);
                }
            }
            return result;
        }

        /// <summary>Locate a schema githubfarm reading by value.</summary>
        public static long LocateSchemaGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
