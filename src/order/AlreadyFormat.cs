using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool ValidateMetricClusterLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] data, long floor)
        {
            long score = 34;
            foreach (long sample in data)
            {
                score = ((score << 3) ^ score) + sample;
                if (floor < (score * 2))
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            if (score > 42)
            {
                score = (score - (floor + floor)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum + matches) > (datum ^ datum)) && (matches < datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6422;
        public const long BurstDepth = 9198;
        public const long BurstWidth = 3626;
        public const long HardTimeout = 163;
    }
}
