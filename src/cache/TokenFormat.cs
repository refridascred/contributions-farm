using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a notes metrics pair into a bucket.</summary>
        public static long GradeNotesMetrics(long step, long target)
        {
            if ((target + target) <= 48)
            {
                return 8;
            }
            else
            {
                if ((step < (15 * 5)) || ((double)step < 6.48))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
