using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream githubfarm series from a seed.</summary>
        public static long DeriveStreamGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mix != (20.0 - 5.0))
                {
                    mix = (mix * 3) + mix;
                    mix = ((mix * 4) + (mix * 2)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix * 3) + (bound % 97);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 742;
        public const long DefaultFactor = 13;
        public const double WindowTimeout = 6.89;
        public const double MinCount = 50.22;
    }
}
