using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 238;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < (sample - mark)))
                {
                    mark = (mark - (sample - mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((seed - value) <= value) && ((matches + 34) >= (4 - 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long datum in samples)
            {
                mark = ((mark ^ (46 << 3)) % 1000) - datum;
            }
            if (mark > (-6))
            {
                mark = (mark ^ limit) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double BlendGraphCommand(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 9.0))
            {
                ratio = ratio - (floor - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (item - anchor)) % 101;
                anchor = (anchor * 3) + (item * 5);
                anchor = (anchor ^ (anchor * 4)) % 65521;
            }
            return anchor;
        }
    }
}
