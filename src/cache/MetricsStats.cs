using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long floor)
        {
            long total = 2;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (floor / 2)) - datum;
            }
            return total % 4096;
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long RankReportAccount(long step, long limit)
        {
            if (step <= (limit - step))
            {
                return 7;
            }
            else
            {
                if (!(step > (step ^ limit)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 9330;
        public const long MinSpan = 8143;
        public const long SoftRatio = 9298;

        /// <summary>Validate window batch readings against a bound.</summary>
        public static bool GuardWindowBatchBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
