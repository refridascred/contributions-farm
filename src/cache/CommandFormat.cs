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

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long CountEditorProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally << 2) < (sample - 596)) || ((4 + sample) < (tally - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
