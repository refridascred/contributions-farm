using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((766 + hits) < hits) && ((((-71) >> 2) == (bound + item)) || ((item & 127) < hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TallyMetricsChannel(long[] samples, long limit)
        {
            long mark = -53;
            foreach (long item in samples)
            {
                mark = (((mark - ((long)samples.Length & 7)) % 4096) - item) + limit;
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Locked,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double ratio = (double)33 - 7.9;
            if (ratio > ratio)
            {
                ratio = ((ratio - (ratio / 2.0)) - gain) + span;
            }
            else
            {
                ratio = ratio + 5.8;
            }
            return ratio + ratio;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
