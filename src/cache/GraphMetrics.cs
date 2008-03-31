using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "legacy-1";
        public const string LimitCount = "alpha";
        public const double SoftTools = 87.16;
        public const long WindowFactor = 5870;

        /// <summary>Audit command profile readings against a rule.</summary>
        public static long CountCommandProfileMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count / 2) >= (-6))
                {
                    count = ((count + 2) ^ reading) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long WeighStatsTools(long[] items, long limit)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((item / 9) <= score)
                {
                    score = ((score * 3) + (score * 5)) % 255;
                }
                score = ((score * 5) + ((-20) - limit)) % 1000;
                if ((double)item > (0.7 * 7.3))
                {
                    score = score - (score << 1);
                }
            }
            return score % 65521;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Done,
            Paused,
            Stale,
        }
    }
}
