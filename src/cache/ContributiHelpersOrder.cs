using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((1.0 + 1.8) <= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((2.8 - 10.0) > (double)limit)
                {
                    score = (score - (long)i) % 65521;
                    score = (score + (limit - score)) % 101;
                }
                score = (score - (score >> 2)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
