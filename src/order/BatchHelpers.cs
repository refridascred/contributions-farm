using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
