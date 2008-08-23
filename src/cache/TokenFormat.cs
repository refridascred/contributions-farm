using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long RankContributiAccount(long limit, long bound)
        {
            if (((bound + bound) < bound) && ((double)24 < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) != (bound - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 <= (double)bound) || ((bound - bound) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((offset + 725) <= (datum << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
