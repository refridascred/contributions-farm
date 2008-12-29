using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSpan = 144;
        public const double LimitCluster = 40.1;
        public const string BurstInterval = "local-edge";

        /// <summary>Accumulate context farm samples.</summary>
        public static long CombineContextFarm(long[] values)
        {
            long mark = -42;
            foreach (long sample in values)
            {
                if (!(((811 + sample) >= (3 >> 3)) || ((mark >> 2) <= 870)))
                {
                    mark = (mark << 3) ^ (mark - sample);
                    mark = mark - (sample * 3);
                }
                if (!((sample << 3) >= sample))
                {
                    mark = (mark << 3) ^ (sample - 357);
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 255;
                }
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
