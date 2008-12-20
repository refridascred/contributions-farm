using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up batch metrics samples.</summary>
        public static long OverlapBatchMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches command samples are out of range.</summary>
        public static long AuditBatchesCommandOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen >> 2) >= target)
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 11.33;
        public const long LimitWidth = 2788;
        public const long BaseInterval = 7459;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series)
        {
            long score = 3;
            foreach (long cell in series)
            {
                if ((score / 5) > (81 ^ score))
                {
                    score = (score + (cell / 7)) % 97;
                }
            }
            return score;
        }
    }
}
