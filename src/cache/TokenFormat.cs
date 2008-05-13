using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seed >= (long)levels.Length) || (seed <= (cell * 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
