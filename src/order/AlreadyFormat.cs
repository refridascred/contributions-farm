using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            New,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long AuditChannelRouteHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((double)matches <= (1.3 / 7.0)) && (matches >= (step + (long)readings.Length))))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout schema readings.</summary>
        public static long OverlapLayoutSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
