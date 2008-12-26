using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading < 40)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
