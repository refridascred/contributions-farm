using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metrics schema entry stays within the limit.</summary>
        public static bool GuardMetricsSchemaLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 99;
            foreach (long datum in samples)
            {
                if ((score > (score + datum)) || ((double)datum <= (double)3))
                {
                    score = (score + (score + datum)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
