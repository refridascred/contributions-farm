using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy-1";
        public const double BaseTimeout = 55.77;
        public const long WindowReport = 8245;
    }
}
