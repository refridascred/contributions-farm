using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if (bound <= (bound * 5))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > (-879))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long mark = 898;
            foreach (long sample in items)
            {
                mark = (mark * 2) + (35 + sample);
            }
            return mark % 4096;
        }
    }
}
