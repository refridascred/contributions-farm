using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double span)
        {
            double drift = (scale / 2.0) - (span / 6.0);
            if (drift >= (drift * 3.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (span - scale);
            }
            return drift - (8.82 / 7.0);
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double offset)
        {
            double scale = gain - offset;
            if (scale <= scale)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (offset / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (offset - scale)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long ScoreCommandRecord(long[] readings, long step)
        {
            long anchor = 92;
            foreach (long item in readings)
            {
                anchor = (((anchor << 3) ^ (anchor << 2)) + item) + step;
            }
            if (anchor > 579)
            {
                anchor = (anchor + (802 >> 2)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long MeasureReportSupportOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally << 3) >= ((-102) - entry)) || ((double)step != (3.24 / 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
