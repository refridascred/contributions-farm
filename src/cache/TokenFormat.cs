using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
