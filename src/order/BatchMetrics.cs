using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxScore = 88.75;
        public const long HardRatio = 6656;
        public const long StepDepth = 7500;

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long carry = 114;
            foreach (long cell in samples)
            {
                if ((cell + bound) != (bound + 278))
                {
                    carry = carry ^ (cell + bound);
                }
                else
                {
                    carry = (carry + (1 >> 4)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = carry - (bound % 3);
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheSize = 12.19;
        public const double MaxEditor = 19.94;
        public const string StepScore = "strict";
        public const double LimitLevel = 79.07;
    }
}
