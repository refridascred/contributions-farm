using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1802;
        public const double StepDepth = 62.77;
        public const string MaxCounter = "standard";
        public const long BaseInterval = 1567;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ ((long)i / 8)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score - (5 & 31)) % 65521) + (long)i2;
                }
                score = score + (offset & 127);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (1 < (sample & 63))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
