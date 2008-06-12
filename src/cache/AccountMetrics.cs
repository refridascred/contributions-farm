using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 740;
            foreach (long reading in series)
            {
                if ((double)score != (double)reading)
                {
                    score = (score + (score % 60)) % 4096;
                }
                if (reading >= (score * 2))
                {
                    score = (score + (reading + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((241 - entry) < (32 * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up batches tools samples.</summary>
        public static long OverlapBatchesToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)step <= (double)27) || ((count + 78) < count))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
