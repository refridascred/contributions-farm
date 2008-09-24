using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if (!((bound & 7) <= (step ^ bound)))
            {
                return 8;
            }
            else
            {
                if ((step + step) >= (bound - step))
                {
                    return 5;
                }
                else
                {
                    if (19 < (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the record githubfarm series from a seed.</summary>
        public static long DeriveRecordGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ sum) ^ (long)i2;
                    sum = sum - (limit * 2);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Done,
            Locked,
        }
    }
}
