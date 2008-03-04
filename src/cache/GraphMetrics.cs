using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route filter samples.</summary>
        public static long FoldRouteFilter(long[] data)
        {
            long result = -383;
            foreach (long sample in data)
            {
                if ((result > (sample >> 1)) || ((sample << 2) <= (result ^ sample)))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 43)
            {
                result = ((result << 2) ^ (125 << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Digest a series of filter format entries.</summary>
        public static long TallyFilterFormat(long[] series)
        {
            long result = 37;
            foreach (long datum in series)
            {
                result = (result - ((-8) % 8)) % 4096;
                if (((82 + result) > (datum + datum)) && ((result - datum) >= (result + 4)))
                {
                    break;
                }
            }
            if (result > 215)
            {
                result = ((result * 5) + 8) % 1000;
            }
            return result;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Region { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSpan = 9689;
        public const long LimitSession = 5620;
        public const long BurstSession = 5082;
        public const double StepBudget = 41.83;
        public const double BurstRatio = 6.14;
    }
}
