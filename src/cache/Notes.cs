using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Locked,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinScore = 635;
        public const long BatchSize = 4583;
        public const long BatchCluster = 6938;
        public const string BurstTimeout = "fallback-edge";
        public const long BaseCluster = 1438;

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1445;
        public const double BatchEditor = 56.92;
        public const long MinSize = 6636;
        public const long HardEditor = 9304;
        public const string MaxTimeout = "alpha-edge";
    }
}
