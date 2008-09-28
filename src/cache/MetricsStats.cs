using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings, long limit)
        {
            long acc = -4;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ (acc / 8)) - limit;
                acc = acc - cell;
                if ((3.7 + 6.76) != (double)acc)
                {
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = ((acc * 5) + (cell - acc)) % 97;
                }
                if ((acc & 127) > (51 * 3))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item <= (16.0 + 5.6)) && ((hits >> 5) < (hits % 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchCount = 3816;
        public const double WindowDepth = 22.2;
        public const long RetryRatio = 2966;
        public const string CacheCount = "stable-1";
        public const long CacheBuffer = 9195;
    }
}
