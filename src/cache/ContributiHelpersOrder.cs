using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long score = 24;
            foreach (long item in readings)
            {
                if ((double)item > (2.7 / 5.0))
                {
                    score = ((score << 3) ^ score) % 101;
                }
                else
                {
                    score = (score + (44 + score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) > (hits ^ 881))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
