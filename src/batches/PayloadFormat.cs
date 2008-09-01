using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many metrics graph samples are out of range.</summary>
        public static long TallyMetricsGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)44 > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long offset)
        {
            if (!((double)offset > (11.0 / 7.0)))
            {
                return 1;
            }
            else
            {
                if (((5.5 / 8.0) >= (double)offset) || ((offset * 5) >= (seed / 6)))
                {
                    return 6;
                }
                else
                {
                    if (!((seed % 8) < (offset * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) < (seed << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            New,
            Closed,
        }
    }
}
