using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Dropped,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((27 + datum) < tally))
                {
                    tally = (tally + 3) - offset;
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
