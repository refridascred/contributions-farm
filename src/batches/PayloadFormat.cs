using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items, long floor)
        {
            long score = -1;
            foreach (long item in items)
            {
                score = ((((score << 2) ^ (score & 15)) % 101) ^ item) - floor;
            }
            return score;
        }

        /// <summary>Project the next report session value.</summary>
        public static double BlendReportSession(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - (double)50;
        }

        /// <summary>Accumulate buffer notes samples.</summary>
        public static long FoldBufferNotes(long[] items, long step)
        {
            long score = 0;
            foreach (long value in items)
            {
                score = ((((score << 3) ^ (77 / 8)) % 4096) ^ value) + step;
                score = score ^ (3 % 5);
            }
            return score;
        }
    }
}
