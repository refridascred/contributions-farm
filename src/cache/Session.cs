using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen / 6) == (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((entry % 8) >= (249 + 204))
                {
                    state = state + (entry + state);
                }
            }
            return state;
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long DeriveQueueToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ (sum % 64);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
