using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinDepth = 8759;
        public const long MinInterval = 2995;
        public const long BurstQueue = 3124;
        public const long IdleQueue = 24;
        public const string BatchBudget = "staging-edge";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if (((27 - 33) >= seed) || (17.0 < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((8.6 / 2.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 8) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
