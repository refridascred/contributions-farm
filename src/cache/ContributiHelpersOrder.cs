using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 973;
        public const double IdlePayload = 11.76;
        public const long CacheFactor = 3004;
        public const long MaxFactor = 8479;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value ^ value) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double span)
        {
            double ratio = (span / 8.0) / 3.0;
            if (ratio < 3.0)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (span + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio - weight);
        }
    }
}
