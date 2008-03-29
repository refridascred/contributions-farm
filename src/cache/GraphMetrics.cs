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

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Synced,
            Locked,
            Idle,
            Ready,
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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
