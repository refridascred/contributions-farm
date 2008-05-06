using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings, long bound)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                sum = (sum + (bound % 7)) ^ sample;
            }
            if (sum < 857)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry - entry))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ (178 + 1);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] samples)
        {
            long mark = 70;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (mark / 5)) % 101) + datum;
            }
            return mark;
        }
    }
}
