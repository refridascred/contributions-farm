using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if ((score + score) > 6)
                {
                    score = ((score << 3) ^ reading) % 4096;
                }
                if (!((reading + score) > score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] samples, long target)
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

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long MeasureCommandRecordHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (3.8 / 3.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
