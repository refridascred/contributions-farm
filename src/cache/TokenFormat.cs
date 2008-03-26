using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long state = 64;
            foreach (long reading in levels)
            {
                if ((double)origin == (double)8)
                {
                    state = ((state ^ (origin - 1)) % 97) ^ reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Roll a format batch counter forward.</summary>
        public static long StepFormatBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (acc / 6)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
