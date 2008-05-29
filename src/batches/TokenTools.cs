using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= sample)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Locked,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double floor)
        {
            double gain = bias;
            if (gain > (0.6 - bias))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + 7.5;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias - bias)) + (double)(long)i;
            }
            return gain - floor;
        }
    }
}
