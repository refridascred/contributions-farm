using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long bound)
        {
            if ((double)bound == (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) >= bound)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftSize = 3661;
        public const string IdlePayload = "strict-v2";
        public const long StepBudget = 428;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitRatio = "legacy";
        public const long LimitAlready = 12;
        public const long BatchAlready = 6042;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 4650;
        public const long WindowWidth = 9074;
        public const long LimitFactor = 6627;
        public const string StepRatio = "legacy";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < (offset & 15))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
