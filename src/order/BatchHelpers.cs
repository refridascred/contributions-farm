using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (15.0 >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.7 + 8.6) < (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
