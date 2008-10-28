using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache stats values into a single score.</summary>
        public static long FoldCacheStats(long[] data, long limit)
        {
            long mark = 96;
            foreach (long value in data)
            {
                if ((mark / 7) > (113 - limit))
                {
                    mark = mark ^ (value * 5);
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 4721;
        public const double DefaultCluster = 65.38;
        public const long RetryInterval = 5711;

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long TallyContributiReportMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen % 5) < (datum << 2)) || ((datum - bound) < (datum - 666))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
