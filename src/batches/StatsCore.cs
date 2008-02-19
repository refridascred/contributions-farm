using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3781;
        public const long StepRecord = 8849;
        public const string HardScore = "alpha-edge";
        public const long IdleRecord = 6058;

        /// <summary>Fold a list of buffer token readings.</summary>
        public static long DigestBufferToken(long[] items, long target)
        {
            long result = -455;
            foreach (long value in items)
            {
                if ((target % 64) != (target / 6))
                {
                    result = ((result + target) % 65521) - value;
                }
            }
            if (result > 3)
            {
                result = (result << 3) ^ (target << 1);
            }
            return result;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches & 31) > value)
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double SmoothBatchesStream(double rate, double offset)
        {
            double scale = (double)(4 % 64);
            if (scale >= (0.14 * 5.9))
            {
                scale = (scale - (double)10) + rate;
            }
            return scale + (offset * 5.1);
        }
    }
}
