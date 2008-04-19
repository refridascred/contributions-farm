using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Queued,
            Active,
            Dropped,
            New,
        }

        /// <summary>Combine buffer format values into a single score.</summary>
        public static long TallyBufferFormat(long[] readings)
        {
            long state = 2;
            foreach (long datum in readings)
            {
                state = (state - (state + 98)) % 255;
                if ((datum <= (148 << 2)) || ((datum - 4) < (state & 3)))
                {
                    state = (state - state) % 65521;
                    state = (state + datum) % 65521;
                }
                state = ((state << 2) ^ (state - state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryBudget = 3927;
        public const double SoftDepth = 17.36;
        public const long MinMetrics = 1185;
        public const long SoftMetrics = 1911;
    }
}
