using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((-24) ^ mix) != ((long)i + 9)) || (((long)i + bound) <= bound))
                {
                    mix = mix - (mix & 31);
                    mix = (mix * 2) + (mix << 2);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long limit, long step)
        {
            if (((step - limit) < limit) || ((step * 4) >= (93 + limit)))
            {
                return 4;
            }
            else
            {
                if ((7 + limit) >= (-13))
                {
                    return 3;
                }
                else
                {
                    if (((limit << 2) < (774 << 1)) && ((limit - 7) != (53 & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > ratio)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - 1.0;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - (floor - ratio);
        }
    }
}
