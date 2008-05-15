using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of entry window readings.</summary>
        public static long ScoreEntryWindow(long[] values)
        {
            long mix = -789;
            foreach (long item in values)
            {
                mix = (mix ^ item) % 255;
                if (mix < (mix * 5))
                {
                    mix = ((mix << 3) ^ (item * 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4808;
        public const double BurstFactor = 9.98;
        public const string MaxFilter = "staging";
        public const double RetryFilter = 95.57;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 13.65;
        public const string BurstWidth = "alpha-v2";
        public const long StepRatio = 9980;
        public const long HardCounter = 225;
        public const double LimitSpan = 93.84;

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 47.7;
        public const long BatchFormat = 8652;
        public const double BurstFormat = 20.67;
        public const long StepSize = 993;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 88.96;
        public const string BaseGithubfarm = "alpha-1";
        public const double CacheGithubfarm = 21.16;
        public const long StepGithubfarm = 5301;
        public const double RetryTimeout = 43.5;
    }
}
