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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
