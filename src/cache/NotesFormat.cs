using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate metrics githubfarm samples.</summary>
        public static long CombineMetricsGithubfarm(long[] series)
        {
            long mark = 76;
            foreach (long datum in series)
            {
                if ((mark + datum) < (2 * 2))
                {
                    mark = (mark + (datum + mark)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long CompareAlreadyNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
