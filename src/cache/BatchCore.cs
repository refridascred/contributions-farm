using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((5.0 - 9.04) == (double)floor))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order payload readings.</summary>
        public static long CombineOrderPayload(long[] data)
        {
            long result = 817;
            foreach (long entry in data)
            {
                if ((double)result >= (double)entry)
                {
                    result = (result + (entry >> 3)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (181 - entry)) % 255;
                }
            }
            if (result > 42)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (7.7 <= (double)matches)
                {
                    matches = ((matches + 2) + entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
