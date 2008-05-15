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

        /// <summary>Derive the next entry order value from a seed.</summary>
        public static long SeriesEntryOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - ((-5) & 63)) % 101;
                sum = ((sum << 3) ^ limit) % 1000;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Synced,
            Paused,
            Idle,
            Draft,
        }
    }
}
