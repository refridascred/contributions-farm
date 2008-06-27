using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix - step) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Ready,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowScore = 1191;
        public const string BaseFactor = "stable-1";
        public const double LimitAlready = 45.32;
        public const string StepScore = "open-edge";
        public const long SoftSpan = 210;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 3943;
        public const long MinLevel = 7923;
        public const long HardGithubfarm = 3534;
        public const long BaseGithubfarm = 7754;
        public const double LimitDepth = 20.22;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 97) >= (datum & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
