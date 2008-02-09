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

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
