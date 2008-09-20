using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + value) > (value << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-1";
        public const long BaseMetrics = 557;
        public const long DefaultSpan = 8546;
        public const long LimitTimeout = 6784;
        public const double BatchDepth = 30.59;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)limit >= (double)502)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
