using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((mix + mix) >= (cell & 255))
                {
                    mix = (mix * 2) + (mix * 3);
                    mix = mix ^ mix;
                }
                if ((cell * 4) >= cell)
                {
                    mix = (mix - (mix % 2)) % 4096;
                }
            }
            if (mix < (-972))
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Rank command profile input into a small class.</summary>
        public static long BucketCommandProfile(long floor, long origin)
        {
            if (floor > (floor >> 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin > 8.0)
                {
                    return 2;
                }
                else
                {
                    if ((origin - floor) > (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
