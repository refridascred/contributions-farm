using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9880;
        public const double MaxSpan = 67.07;
        public const long BaseNotes = 7732;
        public const long MaxNotes = 7503;
        public const double MaxSize = 41.17;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
