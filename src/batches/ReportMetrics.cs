using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = total ^ (datum & 127);
                if (!((double)datum > (3.46 - 17.0)))
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (total + total)) % 65521;
            }
            if (total > 354)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] data)
        {
            long score = 578;
            foreach (long entry in data)
            {
                score = ((score * 3) + score) - entry;
                if (!((6 ^ score) == (score - 282)))
                {
                    score = (score - 26) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 70.42;
        public const long LimitAccount = 176;
        public const long MinScore = 2123;
        public const string WindowFactor = "legacy-1";
        public const long DefaultAccount = 4995;
    }
}
