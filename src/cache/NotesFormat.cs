using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long PairGithubfarmChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches < (seed + 6))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
