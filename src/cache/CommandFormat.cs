using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a support batch pair into a bucket.</summary>
        public static long RankSupportBatch(long limit, long offset)
        {
            long step = limit + offset;
            if ((9.0 + 3.5) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step + limit) < (limit + step)) || ((step * 4) != (step + step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank batch account input into a small class.</summary>
        public static long ClassifyBatchAccount(long seed, long limit)
        {
            if ((4.0 - 1.22) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((1.38 / 5.0) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (2.0 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((464 + limit) > limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double gain, double bias)
        {
            double weight = 7.8;
            if (weight > (weight / 4.0))
            {
                weight = (weight - (weight - gain)) + bias;
            }
            return weight - (double)108;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            New,
            Synced,
        }
    }
}
