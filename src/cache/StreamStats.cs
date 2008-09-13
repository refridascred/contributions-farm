using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1641;
        public const string LimitLevel = "cached";
        public const string StepToken = "staging-1";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 2) ^ 761;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long anchor = 11;
            foreach (long value in readings)
            {
                if (anchor >= origin)
                {
                    anchor = ((anchor << 2) ^ (origin + value)) % 65521;
                }
                anchor = (anchor ^ (origin >> 4)) % 255;
            }
            return anchor;
        }
    }
}
