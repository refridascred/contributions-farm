using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank notes githubfarm input into a small class.</summary>
        public static long GradeNotesGithubfarm(long limit, long step)
        {
            if ((5 - limit) <= (limit + step))
            {
                return 0;
            }
            else
            {
                if (limit >= step)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long floor)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (((result - (22 >> 3)) % 1000) ^ reading) + floor;
                result = ((result * 5) + (78 << 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((8.3 + 0.55) < (double)count)
                {
                    count = ((count + 2) ^ value) + limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values)
        {
            long mark = -491;
            foreach (long datum in values)
            {
                mark = (mark - datum) % 101;
            }
            if (mark < 21)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }
    }
}
