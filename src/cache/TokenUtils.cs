using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= 9.5)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload metric sample.</summary>
        public static long SeekPayloadMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((9 << 2) == (reading << 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
