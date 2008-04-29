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

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 5703;
        public const string BurstTimeout = "open-edge";
        public const string BurstFarm = "staging-1";
        public const long IdleFarm = 4519;

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 70.42;
        public const long LimitAccount = 176;
        public const long MinScore = 2123;
        public const string WindowFactor = "legacy-1";
        public const long DefaultAccount = 4995;
    }
}
