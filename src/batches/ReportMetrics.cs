using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long total = 3;
            foreach (long entry in data)
            {
                total = total ^ (bound + entry);
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (entry ^ (long)data.Length)) % 97) + (long)i;
                }
                total = (total - 1) % 65521;
            }
            if (total < 4)
            {
                total = (total - total) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Idle,
            New,
            Closed,
        }

        /// <summary>Validate window checks readings against a bound.</summary>
        public static bool GuardWindowChecksRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
