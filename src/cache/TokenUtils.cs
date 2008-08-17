using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardDepth = 712;
        public const double SoftNotes = 49.49;
        public const long StepNotes = 5136;
        public const long BurstDepth = 2795;

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long BucketToolsGithubfarm(long step, long origin)
        {
            if (!((double)origin > (9.7 - 15.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 18.0)
                {
                    return 7;
                }
                else
                {
                    if ((origin <= (467 + origin)) || (origin > (origin / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 - 6.0) > (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long total = 2;
            foreach (long cell in data)
            {
                total = total + (total & 15);
                if (!((82 >> 5) >= (total % 8)))
                {
                    total = (total << 2) ^ (total - cell);
                    break;
                }
                total = (total * 3) + (cell + total);
            }
            return total % 4096;
        }
    }
}
