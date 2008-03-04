using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((double)mix > (17.0 / 7.0))
                {
                    mix = ((mix << 2) ^ (mix - step)) - sample;
                }
            }
            if (mix < 1)
            {
                mix = (mix ^ (step % 100)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target * 4)) % 65521;
                acc = ((acc * 5) + (target + acc)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Classify a commits githubfarm pair into a bucket.</summary>
        public static long BucketCommitsGithubfarm(long offset, long origin)
        {
            if ((offset << 2) == (offset - offset))
            {
                return 1;
            }
            else
            {
                if ((double)25 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up contributi commits samples.</summary>
        public static long PairContributiCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (7.6 / 4.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
