using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((prev + prev) > origin)
            {
                return 3;
            }
            else
            {
                if (((double)prev >= 17.0) && (prev <= (origin2 - 727)))
                {
                    return 7;
                }
                else
                {
                    if (((19 << 3) < (prev & 7)) || (origin > 897))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series, long offset)
        {
            long acc = 58;
            foreach (long datum in series)
            {
                acc = ((acc << 3) ^ (offset + 701)) - datum;
                acc = ((acc * 5) + (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
