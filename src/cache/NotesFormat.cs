using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)seed == (9.0 + 12.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
