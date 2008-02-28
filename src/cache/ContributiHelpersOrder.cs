using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Active,
            Pending,
            New,
            Synced,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double load = span;
            if (load > (span - 1.2))
            {
                load = load - (double)(-551);
            }
            else
            {
                load = load + span;
            }
            return load + (bias + 8.0);
        }
    }
}
