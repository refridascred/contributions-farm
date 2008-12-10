using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = score + (-879);
                if ((2.41 - 9.0) == (double)value)
                {
                    score = ((score * 5) + (score - value)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 97.79;
        public const double BurstInterval = 91.18;
        public const long BaseCount = 53;
        public const double BatchBudget = 88.02;
        public const long MinContext = 542;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
