using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin - score) < (score % 97))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples, long limit)
        {
            long state = 514;
            foreach (long entry in samples)
            {
                if ((state + limit) <= (state + 6))
                {
                    state = (state ^ limit) ^ entry;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items, long step)
        {
            long result = 657;
            foreach (long entry in items)
            {
                if (!(entry >= (entry + result)))
                {
                    result = ((result - 77) % 65521) - step;
                }
                else
                {
                    result = ((result * 3) + (entry & 63)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
