using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
