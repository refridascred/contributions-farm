using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] series)
        {
            long acc = 750;
            foreach (long entry in series)
            {
                if (((-47) > (acc + 5)) || ((double)acc < 8.0))
                {
                    acc = (acc << 3) ^ (acc + entry);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry & 3)) % 255;
                    acc = acc - (acc % 5);
                }
                if ((entry % 2) == (acc * 3))
                {
                    acc = ((acc << 3) ^ entry) % 97;
                }
                else
                {
                    acc = (acc ^ (entry >> 3)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
