using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                long lane = result + (123 / 2);
                if (!((offset < ((-142) % 97)) || ((long)i < lane)))
                {
                    result = ((result * 4) + ((-3) + result)) % 4096;
                }
                if (offset <= (long)i)
                {
                    result = result ^ lane;
                    lane = (lane << 2) ^ ((long)i & 127);
                    break;
                }
                else
                {
                    result = (result + offset) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long score = 78;
            foreach (long reading in data)
            {
                if ((double)score <= (4.08 * 11.0))
                {
                    score = (score + (694 - score)) % 97;
                }
                if ((1.66 / 5.0) > (double)reading)
                {
                    break;
                }
            }
            if (score < 29)
            {
                score = (score << 2) ^ (284 >> 5);
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 3192;
        public const string RetryWidth = "cached-edge";
        public const string IdleLevel = "strict";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ seed) % 1000;
                if (!((seed + total) > (long)i))
                {
                    total = total - seed;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
