using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long step)
        {
            long result = 6;
            foreach (long cell in samples)
            {
                if ((double)step < (8.6 * 10.0))
                {
                    result = ((result - (73 % 10)) % 97) + cell;
                }
            }
            if (result < 7)
            {
                result = ((result << 3) ^ (step ^ step)) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Stale,
            Paused,
            Draft,
        }
    }
}
