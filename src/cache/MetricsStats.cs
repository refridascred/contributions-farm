using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 5614;
        public const long DefaultScore = 923;
        public const long RetryFactor = 7118;
        public const long HardBatch = 1976;
        public const long BurstBatch = 1651;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool CheckCommitsGraphRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((9 + step) != (sample % 24)) || ((count * 3) != (count + 63)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
