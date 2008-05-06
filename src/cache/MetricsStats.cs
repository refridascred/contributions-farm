using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long TallyEntryBufferOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell - bound) < matches) || (9 < cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double gain = ratio;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (ratio + gain)) + (double)(long)i) + offset;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 7992;
        public const double MaxPayload = 1.24;
        public const double BurstFactor = 49.9;
        public const string DefaultRatio = "legacy-edge";

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits >= (16.0 / 5.0))
                {
                    hits = ((hits + 1) - sample) - offset;
                }
            }
            return hits;
        }
    }
}
