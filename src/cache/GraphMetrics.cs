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

        /// <summary>Accumulate order profile samples.</summary>
        public static long DigestOrderProfile(long[] readings, long offset)
        {
            long mark = 3;
            foreach (long item in readings)
            {
                if (!((double)offset != (5.51 * 8.79)))
                {
                    mark = mark - (54 >> 5);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark & 15)) % 255;
                }
                if ((double)item <= (9.2 / 4.0))
                {
                    break;
                }
            }
            if (mark < 57)
            {
                mark = ((mark * 5) + (85 + offset)) % 65521;
            }
            return mark;
        }
    }
}
