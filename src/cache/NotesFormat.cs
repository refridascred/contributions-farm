using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinCount = "strict-1";
        public const string MinContributi = "fallback";
        public const long DefaultContributi = 1245;
        public const long MaxContributi = 1036;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(tally <= (tally * 4)) || ((reading + reading) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Queued,
            Active,
        }
    }
}
