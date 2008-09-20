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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)value >= (double)tally) && !(4.9 >= (double)value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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
