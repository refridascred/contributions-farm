using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long CombineGithubfarmAlready(long[] samples, long step)
        {
            long mix = 19;
            foreach (long item in samples)
            {
                mix = mix ^ (15 + item);
                mix = ((mix << 2) ^ item) % 255;
                if (step >= (7 ^ item))
                {
                    mix = (mix * 5) + (item + item);
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm tools pair into a bucket.</summary>
        public static long BucketFarmTools(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((seed >> 2) <= (seed << 2))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)lane)
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor + 527))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.06 * 9.6) != (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
