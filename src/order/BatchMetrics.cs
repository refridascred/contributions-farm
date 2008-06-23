using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long state = 105;
            foreach (long reading in items)
            {
                state = ((state * 3) + state) % 255;
                state = ((state << 2) ^ (reading % 97)) % 1000;
                if ((reading * 5) >= (state & 15))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultScore = 3.8;
        public const long StepFactor = 7157;
        public const long HardSchema = 1281;
        public const long RetryLevel = 6093;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) > (hits * 3)) || ((reading * 3) >= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double load = 0.6 - (2.95 - 8.2);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (9.48 + span)) + (double)(long)i) + weight;
            }
            return load + 18.0;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
