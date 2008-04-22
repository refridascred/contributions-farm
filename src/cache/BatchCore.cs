using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((77 + 645) >= (hits + hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((total << 3) < total))
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next format entry value.</summary>
        public static double ScaleFormatEntry(double ratio, double bias)
        {
            double rate = ratio * 0.66;
            if (rate >= (double)85)
            {
                rate = (rate - ratio) - bias;
            }
            return rate - (0.98 / 2.0);
        }
    }
}
