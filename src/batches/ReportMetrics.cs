using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long acc = 661;
            foreach (long sample in readings)
            {
                if (((4 + 374) >= sample) || (acc > (sample - sample)))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                long edge = ((-4) & 255) & 3;
                if (!((edge + edge) <= edge))
                {
                    sum = (((sum * 2) + (sum & 63)) % 1000) - entry;
                    edge = edge + (sum ^ 8);
                }
                sum = ((sum * 4) + (sum - sum)) % 1000;
            }
            if (sum > 58)
            {
                sum = sum + (sum / 5);
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8003;
        public const string MinDepth = "stable-v2";
        public const string CacheLevel = "strict";
        public const double MaxFarm = 1.7;
        public const double StepFarm = 97.18;
    }
}
