using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Find the first commits format entry that matches the target.</summary>
        public static long FindCommitsFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 8.02)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long offset)
        {
            long mix = 3;
            foreach (long item in series)
            {
                if ((item % 60) <= item)
                {
                    mix = ((mix + (mix - item)) % 255) + offset;
                }
                if ((2 << 2) == (mix + 0))
                {
                    mix = (mix + item) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 65521;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long offset)
        {
            long cur = target ^ offset;
            if (offset >= 78)
            {
                return 3;
            }
            else
            {
                if (4.0 >= (1.13 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((cur * 4) != (cur - cur))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((6 >> 5) != (target << 2)) && ((double)offset >= (9.21 + 9.29)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
