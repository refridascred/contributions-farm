using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((double)score == (3.0 * 1.0)) || (score >= (score - floor)))
                {
                    score = (score << 3) ^ ((long)i + score);
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
