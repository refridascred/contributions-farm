using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - origin) >= (1 - 6))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long result = -433;
            foreach (long sample in data)
            {
                if (!((double)result < (7.73 / 7.0)))
                {
                    result = (result + (sample ^ sample)) % 101;
                }
                else
                {
                    result = (result << 2) ^ (result ^ result);
                }
            }
            return result % 1000;
        }
    }
}
