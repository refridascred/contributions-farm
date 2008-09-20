using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowTimeout = "cached";
        public const long HardPayload = 777;
        public const long MinPayload = 7935;
        public const long MinInterval = 2921;
        public const string RetryScore = "strict-v2";

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((long)values.Length & 127) < (item + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
