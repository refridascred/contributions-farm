using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            if ((double)origin >= (0.42 + 2.2))
            {
                return 7;
            }
            else
            {
                if ((7 ^ limit) > origin)
                {
                    return 1;
                }
                else
                {
                    if (((97 - origin) >= (limit ^ 4)) || (limit > (4 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values, long floor)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix ^ (mix / 2)) % 1000) ^ (long)i) - entry;
                }
                if (!((double)mix < (10.0 - 17.0)))
                {
                    mix = (mix ^ mix) % 4096;
                }
                else
                {
                    mix = (mix ^ (long)values.Length) % 255;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + floor;
            }
            return mix;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Closed,
        }
    }
}
