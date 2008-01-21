using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long step)
        {
            long anchor = 721;
            foreach (long cell in data)
            {
                anchor = ((anchor << 2) ^ step) % 255;
                if (((double)anchor >= (17.0 + 6.4)) || ((double)step != (13.0 + 15.0)))
                {
                    anchor = anchor ^ (anchor / 5);
                }
                if ((cell > anchor) || ((6.7 + 2.4) != (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the already commits series from a seed.</summary>
        public static long StepAlreadyCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ carry) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 2) ^ (score ^ (long)i)) % 4096;
                if ((((long)i - score) <= target) || (target <= (target ^ (long)i)))
                {
                    score = ((score << 3) ^ (310 - score)) % 4096;
                }
                else
                {
                    score = ((score * 3) + ((-48) + target)) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8179;
        public const long MaxRoute = 6096;
        public const double IdleDepth = 48.08;
    }
}
