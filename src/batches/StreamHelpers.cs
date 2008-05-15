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

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 5731;
        public const long BurstCounter = 8428;
        public const long RetryCounter = 6009;
        public const double CacheCounter = 31.37;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long limit)
        {
            if (!(94 > (seed << 2)))
            {
                return 0;
            }
            else
            {
                if ((seed % 100) != (limit % 12))
                {
                    return 2;
                }
                else
                {
                    if ((limit << 1) < (seed >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "fallback";
        public const double HardStats = 20.41;
        public const long SoftStats = 8691;
        public const string StepFactor = "standard";
        public const long IdleScore = 8247;
    }
}
