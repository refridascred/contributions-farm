using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((70 % 10) < hits)
                {
                    hits = ((hits + 2) ^ item) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double bias2 = (bias / 3.0) * 8.0;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias) - gain;
            }
            return bias2 - bias;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const double BurstScore = 12.68;
        public const long MinCount = 4864;

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long anchor = 5;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample - 856)) % 101;
            }
            return anchor % 65521;
        }
    }
}
