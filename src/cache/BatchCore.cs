using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                if (((score ^ score) >= score) && (step >= (score * 2)))
                {
                    score = (score << 2) ^ (step + score);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
