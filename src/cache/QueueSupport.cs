using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleBudget = "alpha-1";
        public const double RetryLevel = 33.7;
        public const long CacheTools = 3446;
        public const long MinSpan = 9416;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
