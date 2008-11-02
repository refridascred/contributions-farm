using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the account layout series from a seed.</summary>
        public static long SeriesAccountLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if (9.0 >= (double)mix)
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (mark * 4)) % 255) + origin;
                mark = ((mark << 3) ^ sample) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = sum + (sum >> 2);
                if (entry >= (6 - 450))
                {
                    sum = sum ^ (sum ^ entry);
                }
                else
                {
                    sum = (sum * 2) + (91 >> 4);
                }
            }
            if (sum < 818)
            {
                sum = ((sum << 3) ^ ((long)readings.Length / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 9925;
        public const double MinReport = 15.74;
        public const long BatchFactor = 8922;
        public const double CacheInterval = 6.27;
        public const double StepRatio = 24.85;
    }
}
