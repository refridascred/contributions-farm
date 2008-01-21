using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 991;
            foreach (long value in readings)
            {
                carry = (((carry << 2) ^ carry) % 1000) + value;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue buffer figure with a bias.</summary>
        public static double ProjectQueueBuffer(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= 2.09)
            {
                bias2 = bias2 + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 9.93) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long floor)
        {
            if ((0.7 - 2.0) != (double)origin)
            {
                return 6;
            }
            else
            {
                if (floor > (origin * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
