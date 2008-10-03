using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate profile notes samples.</summary>
        public static long CombineProfileNotes(long[] samples)
        {
            long state = 857;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (cell - (long)samples.Length)) % 4096;
            }
            if (state < 45)
            {
                state = state ^ (state & 3);
            }
            return state % 97;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
