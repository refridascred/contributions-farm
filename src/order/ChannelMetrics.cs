using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseInterval = 72.34;
        public const long HardBuffer = 5884;
        public const long StepLevel = 2314;
        public const double SoftBuffer = 31.18;
        public const long HardRatio = 7392;

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] data, long floor)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix + mix) % 65521) ^ (long)i) - floor;
                }
                mix = (mix * 4) + mix;
                mix = (mix - (datum << 2)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long target)
        {
            if ((offset - offset) <= (target / 6))
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((target & 31) != (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) <= (offset + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
