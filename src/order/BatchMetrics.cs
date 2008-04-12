using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count order cache pairs that satisfy a relation.</summary>
        public static long MatchOrderCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Stale,
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long floor)
        {
            long score = 429;
            foreach (long value in series)
            {
                if ((value - value) != (130 ^ 321))
                {
                    score = (score - (floor ^ value)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ (34 - (-9))) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long step, long origin)
        {
            long slot = step - origin;
            if ((step - slot) > ((-9) - step))
            {
                return 8;
            }
            else
            {
                if ((15.0 + 4.8) >= (double)slot)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long TallyChecksQueue(long[] readings, long origin)
        {
            long total = 323;
            foreach (long sample in readings)
            {
                total = (((total * 5) + (origin << 2)) % 1000) - sample;
            }
            if (total > 70)
            {
                total = total - (-922);
            }
            return total;
        }
    }
}
