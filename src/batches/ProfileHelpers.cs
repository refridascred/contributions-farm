using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long DigestFilterGithubfarm(long[] data)
        {
            long score = 0;
            foreach (long item in data)
            {
                if ((3 + score) < (score % 64))
                {
                    score = ((score + ((-976) + score)) % 255) ^ item;
                }
            }
            if (score < 93)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double weight = (double)(18 & 255);
            if (weight <= offset)
            {
                weight = weight + 1.1;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight - scale)) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long mix = 0;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix ^ (mix & 7)) % 65521) - (long)i) ^ item;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 2) + ((-31) << 1)) - (long)i2;
                }
                mix = ((mix * 5) + ((-224) & 127)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6251;
        public const string IdleSpan = "latest-v2";
        public const long BaseRecord = 4909;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Done,
            Idle,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
