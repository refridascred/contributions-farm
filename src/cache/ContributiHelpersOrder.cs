using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxSpan = 92.07;
        public const string IdleGithubfarm = "stable";
        public const long BurstGithubfarm = 5758;
        public const string DefaultRatio = "legacy-1";

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double bias = (9.7 * 6.67) * 0.5;
            if (bias > (double)(-3))
            {
                bias = (bias + weight) + offset;
            }
            return bias - weight;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long mix = 77;
            foreach (long value in data)
            {
                if ((value + mix) >= (mix - value))
                {
                    mix = (mix * 4) + (mix + value);
                }
                else
                {
                    mix = (mix << 2) ^ (value / 4);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (mix & 7)) % 101;
            }
            return mix % 97;
        }
    }
}
