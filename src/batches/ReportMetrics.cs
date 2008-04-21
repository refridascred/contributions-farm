using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels, long offset)
        {
            long result = 862;
            foreach (long reading in levels)
            {
                result = result - (offset % 12);
                if ((result - reading) >= result)
                {
                    break;
                }
            }
            if (result > 970)
            {
                result = (result ^ 460) % 97;
            }
            return result % 4096;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
