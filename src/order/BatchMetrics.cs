using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (28 > (reading + 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel command series from a seed.</summary>
        public static long IterateChannelCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i + score) > target)
                {
                    score = score - (score * 2);
                    score = ((score << 3) ^ (target % 16)) % 101;
                }
                if (((score ^ target) > (score - score)) || ((target - score) > target))
                {
                    score = ((score * 4) + (target & 63)) % 65521;
                    score = score ^ (score << 3);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long state = 980;
            foreach (long datum in samples)
            {
                if ((266 - state) < (state << 2))
                {
                    state = (((state << 3) ^ (609 / 5)) % 65521) ^ datum;
                }
                else
                {
                    state = (state + (state - (long)samples.Length)) % 65521;
                }
            }
            if (state < 2)
            {
                state = (state << 2) ^ (state - state);
            }
            return state;
        }

        /// <summary>Grade a stats profile value against two limits.</summary>
        public static long GradeStatsProfile(long seed, long offset)
        {
            if (((14.0 + 10.0) == (double)offset) && (seed <= (seed + 28)))
            {
                return 6;
            }
            else
            {
                if ((4.94 * 2.8) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Synced,
            Draft,
            Idle,
            Queued,
        }
    }
}
