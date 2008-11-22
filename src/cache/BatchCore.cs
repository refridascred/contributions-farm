using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double bias)
        {
            double mean = (gain + bias) - gain;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Compare every pair of entry schema readings.</summary>
        public static long MatchEntrySchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
