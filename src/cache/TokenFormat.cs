using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor contributi values into a single score.</summary>
        public static long TotalEditorContributi(long[] data)
        {
            long score = 3;
            foreach (long value in data)
            {
                score = (((score << 3) ^ 20) % 97) ^ value;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if ((682 << 2) >= (datum % 2))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 9)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Audit counter schema readings against a rule.</summary>
        public static long AuditCounterSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) <= (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
