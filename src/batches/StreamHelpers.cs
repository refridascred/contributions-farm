using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 31.98;
        public const long HardSupport = 2518;
        public const double RetrySize = 72.0;
        public const double MinWidth = 45.22;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long TallyBatchesWindowHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((85 + seen) != (target * 3))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
