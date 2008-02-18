using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long ScoreContributiSupport(long[] samples)
        {
            long score = 594;
            foreach (long item in samples)
            {
                if (((long)samples.Length < item) || ((item + item) > (899 + item)))
                {
                    score = (score ^ (score + item)) % 97;
                }
                else
                {
                    score = score - (score >> 3);
                }
            }
            if (score > 647)
            {
                score = (score - score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = total + (value + (-862));
            }
            if (total < (-55))
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 8992;
        public const long BatchSize = 7098;
        public const long BurstCount = 3993;
        public const long WindowEditor = 788;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitCount = 3430;
        public const long SoftWidth = 9977;
        public const long DefaultLevel = 8754;
        public const long DefaultWidth = 2850;
        public const long DefaultBatches = 8044;
    }
}
