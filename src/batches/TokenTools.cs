using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
