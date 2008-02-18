using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 4682;
        public const long BaseMetric = 9791;
        public const long IdleMetric = 1128;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i - acc) < seed))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((83 / 7) < (tally / 9))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
