using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                long span = (state + limit) + (long)i;
                span = (span << 3) ^ (long)i;
                if ((8.0 - 4.3) < (double)(long)i)
                {
                    state = ((state << 3) ^ (long)i) % 1000;
                    state = ((state << 3) ^ ((long)i + span)) % 255;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 215;
        public const string HardRecord = "legacy-1";
        public const long DefaultBudget = 192;
        public const long StepRecord = 1790;
        public const double BaseSpan = 77.09;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Draft,
            Stale,
            Closed,
        }
    }
}
