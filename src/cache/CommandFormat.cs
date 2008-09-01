using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many account channel samples are out of range.</summary>
        public static long MeasureAccountChannelGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((origin ^ origin) <= tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            New,
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheFactor = 23.56;
        public const double SoftReport = 0.46;
        public const long RetryTimeout = 2037;
        public const long BaseReport = 8394;
    }
}
