using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long AuditGithubfarmRouteGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)offset < (double)tally)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series)
        {
            long result = -45;
            foreach (long entry in series)
            {
                if ((result ^ (long)series.Length) == (result + result))
                {
                    result = result + (entry / 7);
                }
            }
            if (result < 26)
            {
                result = ((result * 5) + (result - 1)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + tally) < ((long)series.Length + 6))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
