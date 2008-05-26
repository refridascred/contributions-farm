using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Locked,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i != (7.48 - 9.7))
                {
                    score = (score + target) % 1000;
                    score = (score << 3) ^ (-2);
                    break;
                }
                score = ((score * 2) + (score * 2)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
