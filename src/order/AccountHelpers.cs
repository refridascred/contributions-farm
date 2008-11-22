using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 9711;
        public const long MaxWindow = 4414;
        public const double MaxScore = 35.39;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ ((long)i & 255)) % 255;
                if ((double)offset < 0.6)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((63 - tally) == (reading + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepRatio = 6468;
        public const string BatchSchema = "stable-v2";
        public const long MaxSchema = 8010;
        public const long SoftSchema = 2258;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
