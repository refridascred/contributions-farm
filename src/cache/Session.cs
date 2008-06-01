using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchRatio = "strict-1";
        public const double BurstBudget = 67.3;
        public const double MinCluster = 77.72;
        public const long DefaultLevel = 6832;

        /// <summary>Validate payload filter readings against a bound.</summary>
        public static bool GuardPayloadFilterRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long seed)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if ((seed + cell) < (mark ^ (long)data.Length))
                {
                    mark = mark ^ (seed ^ 63);
                }
                else
                {
                    mark = mark - (seed + 750);
                    mark = (mark - (mark & 1)) % 255;
                }
                mark = (mark + (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
