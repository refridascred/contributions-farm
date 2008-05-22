using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Synced,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate schema window samples.</summary>
        public static long WeighSchemaWindow(long[] readings)
        {
            long score = 8;
            foreach (long value in readings)
            {
                score = ((score + 314) % 4096) - value;
            }
            if (score > 4)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a metrics stats sample.</summary>
        public static long SeekMetricsStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((seen % 3) != (352 + seed)) || ((double)item < (4.3 + 4.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
