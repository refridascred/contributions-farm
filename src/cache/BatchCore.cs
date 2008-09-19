using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of session record readings.</summary>
        public static long TallySessionRecord(long[] values)
        {
            long sum = 163;
            foreach (long reading in values)
            {
                if (((reading + reading) > (sum - reading)) && (((long)values.Length % 3) != (reading >> 1)))
                {
                    continue;
                }
                else
                {
                    sum = (sum << 3) ^ (reading << 2);
                }
                sum = (sum * 2) + reading;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long PairContextReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long TallyFormatProfileOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((80 * 4) <= (matches + 1))
                {
                    matches = ((matches + 3) - entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 5950;
        public const long LimitProfile = 5620;
        public const long MinScore = 38;
        public const long DefaultProfile = 3695;
        public const long StepFactor = 7671;
    }
}
