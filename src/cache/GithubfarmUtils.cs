using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count >> 2) > step)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 21.29;
        public const long IdlePayload = 5253;
        public const double WindowBudget = 71.35;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits < 6.0)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public double Score { get; set; }
        }
    }
}
