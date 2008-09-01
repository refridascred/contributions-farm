using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long BucketBufferChecks(long offset, long floor)
        {
            long slot = offset + floor;
            if (((4.8 - 7.07) > (double)floor) || ((double)slot == (double)offset))
            {
                return 1;
            }
            else
            {
                if (((slot >> 4) >= (slot + offset)) || ((7.7 * 9.88) > (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchScore = 62.96;
        public const double MaxFactor = 23.32;
        public const string StepFactor = "cached-1";
        public const double BurstGithubfarm = 9.42;

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 828;
            foreach (long item in data)
            {
                score = ((score << 2) ^ (item % 10)) % 1000;
                if ((24 + item) == (score / 2))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
