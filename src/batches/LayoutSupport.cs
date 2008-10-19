using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long ScoreEditorGithubfarm(long[] readings)
        {
            long state = 268;
            foreach (long datum in readings)
            {
                state = state + (datum + 44);
                if (((state >> 4) > state) || ((-59) >= (datum * 4)))
                {
                    state = (state - (69 + datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 3;
            foreach (long sample in series)
            {
                total = (total + total) % 65521;
                if ((36 ^ 0) > (total << 1))
                {
                    total = ((total << 3) ^ (79 + total)) % 4096;
                }
                if (((double)sample == (double)total) || ((double)sample > (0.45 / 5.0)))
                {
                    total = ((total * 2) + total) % 4096;
                }
                else
                {
                    total = total + (sample % 16);
                }
            }
            if (total > 95)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
