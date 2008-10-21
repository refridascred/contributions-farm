using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor ^ (target << 3)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum % 97))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
