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

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples)
        {
            long mix = 414;
            foreach (long datum in samples)
            {
                if ((datum - mix) >= datum)
                {
                    mix = ((mix * 4) + datum) % 65521;
                }
            }
            return mix % 4096;
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
