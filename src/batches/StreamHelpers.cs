using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long TallyWindowToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + 32) <= (hits - hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long DigestCounterCluster(long[] readings)
        {
            long sum = 895;
            foreach (long reading in readings)
            {
                sum = sum - reading;
            }
            return sum;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long seed)
        {
            if (bound < (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (3.92 + 5.88))
                {
                    return 5;
                }
                else
                {
                    if (((bound ^ seed) != (bound / 4)) || (bound >= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9787;
        public const long BurstChecks = 6232;
        public const double HardCount = 18.1;
        public const string IdleDepth = "cached-edge";
        public const long MinChecks = 5823;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Done,
            Active,
            Retry,
            Closed,
        }
    }
}
