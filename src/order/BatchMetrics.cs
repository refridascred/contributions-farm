using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long result = 3;
            foreach (long cell in data)
            {
                if ((1.9 - 6.9) < (double)cell)
                {
                    result = (result << 3) ^ (result - result);
                }
                if ((result ^ cell) <= result)
                {
                    result = (result ^ ((long)data.Length + 73)) % 97;
                }
                else
                {
                    result = (result + (43 / 3)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + (seed % 100);
                if (!((result ^ result) > (-9)))
                {
                    continue;
                }
                result = (result << 3) ^ seed;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((0.16 / 5.0) >= (double)(long)values.Length)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxBudget = 1798;
        public const string HardBudget = "alpha";
        public const long LimitSpan = 6862;
        public const string BurstEditor = "cached-1";

        /// <summary>Check that every cluster stream entry stays within the limit.</summary>
        public static bool GuardClusterStreamLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }
    }
}
