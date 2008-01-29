using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(bound < (cell % 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
