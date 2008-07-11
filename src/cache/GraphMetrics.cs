using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4750;
        public const string LimitEditor = "staging";
        public const long RetryScore = 5786;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((total >> 5) == (target & 31))
                {
                    total = (total - (long)i) % 101;
                    total = (total * 2) + 374;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((3.0 + 9.7) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
