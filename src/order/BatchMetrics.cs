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

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = sum - (sum + origin);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Rank queue token input into a small class.</summary>
        public static long BucketQueueToken(long limit, long offset)
        {
            if (((limit * 3) >= (74 ^ offset)) && ((double)offset > (5.93 * 0.79)))
            {
                return 8;
            }
            else
            {
                if (limit > (limit - offset))
                {
                    return 2;
                }
                else
                {
                    if (((offset + limit) <= offset) && ((limit << 3) >= limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
