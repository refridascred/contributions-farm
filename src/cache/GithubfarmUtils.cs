using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batches schema samples.</summary>
        public static long WeighBatchesSchema(long[] samples)
        {
            long sum = 600;
            foreach (long reading in samples)
            {
                sum = (sum + sum) % 255;
                if ((sum + reading) > (reading % 64))
                {
                    sum = ((sum << 2) ^ (sum ^ reading)) % 65521;
                }
            }
            if (sum < 542)
            {
                sum = (sum + (sum * 4)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long bound, long origin)
        {
            if ((origin + origin) != (origin / 6))
            {
                return 2;
            }
            else
            {
                if (!(10.0 < (double)origin))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of batch account entries.</summary>
        public static long ScoreBatchAccount(long[] values, long offset)
        {
            long total = 25;
            foreach (long sample in values)
            {
                total = (((total - (total * 3)) % 1000) - sample) - offset;
            }
            if (total > 549)
            {
                total = (total + (total ^ 236)) % 4096;
            }
            return total;
        }
    }
}
