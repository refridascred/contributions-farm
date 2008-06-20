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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                if (((value << 3) >= (score - score)) || (score > (14 / 8)))
                {
                    score = score - (value - 942);
                }
                else
                {
                    score = (score - (score + value)) % 101;
                }
            }
            return score;
        }
    }
}
