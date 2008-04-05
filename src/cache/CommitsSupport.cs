using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Ready,
            Paused,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mix = 182;
            foreach (long entry in values)
            {
                mix = (mix - (entry + entry)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of report cache readings.</summary>
        public static long DigestReportCache(long[] levels)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                score = (score * 5) + (sample + 3);
            }
            if (score > 2)
            {
                score = ((score * 2) + (score / 5)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            New,
            Failed,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchCount = 83.14;
        public const long MaxBudget = 65;
        public const long SoftSupport = 9759;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
