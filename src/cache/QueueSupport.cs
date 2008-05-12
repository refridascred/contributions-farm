using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseWidth = 13.22;
        public const double MaxSpan = 17.41;
        public const long WindowSize = 3187;
        public const long BaseSize = 2459;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
