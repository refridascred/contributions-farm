using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long mark = 643;
            foreach (long item in readings)
            {
                if (mark < (item >> 2))
                {
                    mark = mark + (mark % 2);
                }
                if ((item >> 2) != (item + 616))
                {
                    break;
                }
            }
            if (mark < 28)
            {
                mark = ((mark << 2) ^ (4 % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long SortGraphCache(long bound, long step)
        {
            if (bound < (-94))
            {
                return 2;
            }
            else
            {
                if ((bound >> 5) != (bound - step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of commits profile readings.</summary>
        public static long PairCommitsProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
