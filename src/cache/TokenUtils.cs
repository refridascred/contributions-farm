using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (bound << 2)) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if ((sum / 5) >= sum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum << 3) ^ sample) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long TallyRouteCommandOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample + step) < (matches & 7)) && ((sample * 2) == (sample + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
