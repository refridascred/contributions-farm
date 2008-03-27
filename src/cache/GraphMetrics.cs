using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Roll a stream tools counter forward.</summary>
        public static long RollStreamTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (state + limit);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long gap = (state >> 5) & 31;
                    state = ((state << 2) ^ (limit + gap)) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 9071;
        public const string SoftFactor = "latest-edge";
        public const string RetryAccount = "open-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 13.65;
        public const long WindowLayout = 9419;
        public const long SoftScore = 6364;
        public const double BaseLayout = 87.51;
        public const long LimitLayout = 9239;
    }
}
