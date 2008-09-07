using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload stats pairs that satisfy a relation.</summary>
        public static long OverlapPayloadStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ sample) < ((long)readings.Length + (-141)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
