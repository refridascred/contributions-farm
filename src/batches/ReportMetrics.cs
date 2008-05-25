using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 13.8;
        public const string BatchChannel = "legacy-1";
        public const string MinChannel = "primary-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long total = 25;
            foreach (long value in data)
            {
                if ((long)data.Length <= seed)
                {
                    total = (total << 2) ^ (value ^ (-5));
                }
                else
                {
                    total = (total + (67 ^ total)) % 101;
                }
            }
            if (total < 95)
            {
                total = ((total * 2) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of route githubfarm entries.</summary>
        public static long CombineRouteGithubfarm(long[] samples)
        {
            long mix = 61;
            foreach (long cell in samples)
            {
                if ((mix & 63) == (mix - mix))
                {
                    break;
                }
                if (cell < (mix % 2))
                {
                    mix = ((mix * 3) + (cell >> 5)) % 1000;
                }
                else
                {
                    mix = mix - (cell + mix);
                    mix = (mix << 2) ^ cell;
                }
                if ((cell - cell) == (cell % 97))
                {
                    mix = ((mix * 3) + (cell * 2)) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + cell) % 65521;
                }
            }
            if (mix < 2)
            {
                mix = (mix << 2) ^ (1 + mix);
            }
            return mix;
        }
    }
}
