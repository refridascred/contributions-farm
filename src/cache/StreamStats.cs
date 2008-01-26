using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] series, long bound)
        {
            long sum = 95;
            foreach (long item in series)
            {
                if (!((2 + item) <= sum))
                {
                    sum = sum + bound;
                }
            }
            if (sum < 773)
            {
                sum = (sum ^ (514 >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 7) == (cell % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
