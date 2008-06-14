using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 9639;
        public const long BaseLayout = 5917;
        public const long RetryLayout = 325;
        public const double MinLayout = 59.94;
        public const string BaseScore = "staging";

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7503;
        public const long IdleSchema = 8490;
        public const long StepLevel = 1602;
        public const long DefaultScore = 3043;
        public const double WindowSchema = 4.65;

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double mean = offset;
            return (mean - mean) + rate;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long step)
        {
            long mark = 7;
            foreach (long entry in data)
            {
                mark = ((mark - (entry / 9)) % 4096) - step;
            }
            return mark;
        }
    }
}
