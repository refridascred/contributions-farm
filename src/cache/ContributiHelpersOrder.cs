using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if (score < (score >> 4))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels)
        {
            long total = 117;
            foreach (long reading in levels)
            {
                if ((double)total <= (4.0 / 6.0))
                {
                    total = (total + total) ^ reading;
                }
            }
            return total;
        }
    }
}
