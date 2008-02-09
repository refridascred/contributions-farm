using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool VerifyFormatFarmRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit layout batches readings against a rule.</summary>
        public static long AuditLayoutBatchesOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((9 - origin) > 310)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine window stream values into a single score.</summary>
        public static long CombineWindowStream(long[] values, long limit)
        {
            long acc = -807;
            foreach (long entry in values)
            {
                if ((acc <= (entry % 5)) && ((double)acc > (7.78 - 8.0)))
                {
                    acc = (acc + entry) - limit;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long offset)
        {
            if ((3.0 / 6.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if (((double)bound >= (4.89 + 4.0)) && (9.0 <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (((bound + offset) != (bound ^ offset)) || ((5.01 - 1.1) == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
