using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long limit)
        {
            long state = 17;
            foreach (long cell in readings)
            {
                if ((cell - state) > (limit + state))
                {
                    state = ((state * 3) + (limit >> 5)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 58.46;
        public const long MinGraph = 8037;
        public const long MaxGraph = 9693;
        public const string LimitScore = "staging-edge";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
