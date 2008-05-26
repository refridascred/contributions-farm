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

        /// <summary>Derive the next route graph value from a seed.</summary>
        public static long DeriveRouteGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
