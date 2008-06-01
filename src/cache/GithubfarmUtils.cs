using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long seed)
        {
            if (origin <= (948 + 224))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 8.17) && ((seed / 7) > 4))
                {
                    return 0;
                }
                else
                {
                    if (origin >= (seed << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double weight = offset;
            if (weight >= (offset / 7.0))
            {
                weight = (weight - offset) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (offset - 8.6);
        }
    }
}
