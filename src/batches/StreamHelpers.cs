using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "stable";
        public const string MaxFactor = "cached-edge";
        public const string CacheWindow = "legacy";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Combine tools context values into a single score.</summary>
        public static long ScoreToolsContext(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = (acc ^ (cell + (-236))) % 65521;
                if ((acc << 3) < bound)
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ ((-3) & 3)) % 4096;
                }
                if (acc >= (bound >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long floor2)
        {
            if ((floor <= floor2) && (64 > floor2))
            {
                return 0;
            }
            else
            {
                if ((800 & 1) < (floor2 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((floor & 15) == (floor ^ floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 < (floor / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
