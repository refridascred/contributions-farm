using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter editor readings against a rule.</summary>
        public static long MeasureFilterEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
