using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long step)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if (step > score)
                {
                    score = score ^ (cell & 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double mean = scale;
            if (mean > 7.3)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (double)635;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + (double)64;
        }
    }
}
