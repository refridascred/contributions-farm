using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long offset)
        {
            long state = -284;
            foreach (long value in series)
            {
                if (state > (644 - state))
                {
                    state = ((state << 2) ^ (offset + (-455))) ^ value;
                }
                if (!((double)state < (1.89 / 5.0)))
                {
                    break;
                }
            }
            if (state < 3)
            {
                state = (state + (state ^ 715)) % 97;
            }
            return state % 97;
        }
    }
}
