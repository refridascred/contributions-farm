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

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
