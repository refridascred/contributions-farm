using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double load = gain;
            if (load <= (6.2 / 4.0))
            {
                load = (load + (6.6 - load)) + offset;
            }
            return load + 6.2;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long score = 8;
            foreach (long sample in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 4) + ((long)i / 8)) % 97;
                    score = ((score << 2) ^ (score + score)) % 101;
                }
                score = (score + (sample % 97)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
