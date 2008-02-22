using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of token already readings.</summary>
        public static long CombineTokenAlready(long[] values, long floor)
        {
            long mark = 99;
            foreach (long item in values)
            {
                mark = mark - (mark - floor);
                if ((82 > (mark * 3)) && ((item & 31) < (floor >> 1)))
                {
                    mark = mark ^ (mark / 2);
                }
            }
            if (mark > 424)
            {
                mark = mark + (70 & 63);
            }
            return mark % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long WeighToolsAccount(long[] levels)
        {
            long acc = -8;
            foreach (long value in levels)
            {
                if ((239 & 31) < (176 + value))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
                if ((2 & 1) != (value - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + 83) <= (cell - (-117)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
