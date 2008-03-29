using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long step)
        {
            long result = -883;
            foreach (long sample in items)
            {
                if ((sample > (result + (long)items.Length)) && ((double)step <= 4.0))
                {
                    result = (result << 2) ^ 82;
                }
            }
            if (result < 50)
            {
                result = result - (result + result);
            }
            return result % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheRatio = "strict-edge";
        public const long SoftFilter = 3744;
        public const string WindowDepth = "primary-edge";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series, long seed)
        {
            long result = 40;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result * 2) + (18 ^ seed)) % 97) - (long)i;
                }
                result = (result << 2) ^ (result >> 1);
                if ((465 % 100) < (result + result))
                {
                    result = (result + ((long)series.Length * 2)) % 65521;
                }
                else
                {
                    result = (result ^ (result - result)) % 101;
                }
                if ((result > (result - sample)) || ((1.7 - 9.58) >= (double)seed))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
