using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] series, long origin)
        {
            long mix = 37;
            foreach (long sample in series)
            {
                if ((sample << 1) >= ((long)series.Length % 64))
                {
                    mix = ((mix * 4) + ((long)series.Length + mix)) % 97;
                }
                if ((0.76 < (double)origin) && ((mix >> 3) != (sample << 3)))
                {
                    mix = ((mix * 5) + (origin * 5)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
