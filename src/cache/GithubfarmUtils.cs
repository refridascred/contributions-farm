using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((hits - hits) <= (hits % 16)) || ((hits << 2) <= 9)) && (item >= hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Scale a token route figure with a bias.</summary>
        public static double ProjectTokenRoute(double ratio, double span)
        {
            double gain = 8.9;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - ratio) - (double)(long)i) + span;
            }
            return gain + (double)0;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
