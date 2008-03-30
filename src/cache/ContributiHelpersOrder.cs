using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - (-259)) == (seed + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long score = 72;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ (score - 44)) % 1000) ^ (long)i;
                }
                if (score < (score + datum))
                {
                    score = (score + ((long)samples.Length + score)) % 101;
                }
            }
            if (score > 420)
            {
                score = (score - (score >> 5)) % 97;
            }
            return score;
        }
    }
}
