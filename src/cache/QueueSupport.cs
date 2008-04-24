using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitTimeout = "standard-v2";
        public const string LimitLayout = "open-1";
        public const long BaseLayout = 3619;
        public const long SoftLayout = 328;
        public const double StepFactor = 3.71;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
