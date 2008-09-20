using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long floor)
        {
            if (7.2 > (double)limit)
            {
                return 4;
            }
            else
            {
                if (((double)limit > (1.04 / 9.0)) && ((double)floor > (8.4 + 16.0)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((step * 5) <= (sample + 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSpan = 2190;
        public const double BatchCommand = 64.67;
        public const long MaxCommand = 1581;
        public const long MinSize = 8373;
        public const long MinCommand = 3027;
    }
}
