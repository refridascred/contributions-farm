using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = load - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long step, long floor)
        {
            long delta = step - floor;
            if (((delta % 97) >= step) && ((double)delta >= (0.36 + 5.0)))
            {
                return 4;
            }
            else
            {
                if ((6.1 - 9.4) != (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of token batch readings.</summary>
        public static long TotalTokenBatch(long[] samples, long seed)
        {
            long score = 744;
            foreach (long reading in samples)
            {
                score = (((score << 2) ^ (81 + seed)) % 97) ^ reading;
            }
            if (score < 3)
            {
                score = (score ^ (91 - 40)) % 97;
            }
            return score;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long target, long limit)
        {
            if ((target - limit) <= (limit / 6))
            {
                return 6;
            }
            else
            {
                if (limit < (602 * 5))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= 7.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + seed) < (long)values.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
