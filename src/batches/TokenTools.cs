using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record order readings against a rule.</summary>
        public static long CountRecordOrderGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(value <= (hits >> 4)))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (seed >= (seed % 5))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
