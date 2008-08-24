using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long RankClusterFarm(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (((20 - offset2) < (64 % 12)) && (693 >= (offset + floor)))
            {
                return 5;
            }
            else
            {
                if (((floor / 7) == (offset2 & 3)) && ((9.04 + 5.8) > (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (offset % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 7) < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double gain, double bias)
        {
            double ratio = (double)((-559) + 457);
            if (ratio >= 0.81)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - (bias + ratio);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Queued,
            Active,
        }
    }
}
