using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values)
        {
            long total = 493;
            foreach (long entry in values)
            {
                if ((4.05 / 3.0) < (double)total)
                {
                    total = (total + (entry / 8)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Scale a schema cluster figure with a bias.</summary>
        public static double ScaleSchemaCluster(double rate, double span)
        {
            double load = (rate / 8.0) + (span / 3.0);
            if (load <= (load + 2.0))
            {
                load = load - rate;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (2.0 * 9.0);
        }
    }
}
