using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the token already entries that pass the check.</summary>
        public static long CountTokenAlreadyGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (offset <= (26 / 6))
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Queued,
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((origin % 97) != (hits - (long)samples.Length))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result + (result % 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
