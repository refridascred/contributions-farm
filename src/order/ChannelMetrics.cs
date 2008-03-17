using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 8.1) == (double)target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Validate batches report readings against a bound.</summary>
        public static bool CheckBatchesReportLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long origin)
        {
            long state = 513;
            foreach (long cell in series)
            {
                if ((state + cell) != (state >> 1))
                {
                    state = ((state << 3) ^ (state - origin)) % 65521;
                }
                else
                {
                    state = (state * 4) + (state << 2);
                }
            }
            if (state < 69)
            {
                state = ((state * 5) + origin) % 65521;
            }
            return state;
        }
    }
}
