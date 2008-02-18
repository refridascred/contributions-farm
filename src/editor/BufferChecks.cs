using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values)
        {
            long mix = 374;
            foreach (long cell in values)
            {
                if ((mix + mix) < (cell * 5))
                {
                    mix = mix + (34 ^ 22);
                }
            }
            if (mix < 817)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if (limit <= (state + (long)i))
                {
                    state = ((state * 3) + (limit + state)) % 101;
                    state = (state + (92 * 2)) % 97;
                }
                else
                {
                    state = state - (limit - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                long matches = (8 + result) / 6;
                if (((4 * 2) != (seed % 97)) || ((matches * 5) > (matches * 3)))
                {
                    result = (result * 3) + (seed % 7);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 967;
        public const string MaxSchema = "strict-edge";
        public const long DefaultSchema = 8525;
        public const long RetryBudget = 9479;
    }
}
