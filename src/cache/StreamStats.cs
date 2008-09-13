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

        /// <summary>Combine githubfarm metric values into a single score.</summary>
        public static long CombineGithubfarmMetric(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                if ((758 >> 5) >= anchor)
                {
                    anchor = ((anchor * 4) + (anchor / 2)) ^ sample;
                }
            }
            if (anchor < 1)
            {
                anchor = anchor - anchor;
            }
            return anchor % 65521;
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
