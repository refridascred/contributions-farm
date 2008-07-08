using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((9 % 12) != ((long)i << 2)))
                {
                    anchor = (anchor * 3) + (step << 1);
                }
                anchor = ((anchor * 4) + (step + anchor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next payload profile value.</summary>
        public static double AdjustPayloadProfile(double bias, double floor)
        {
            double mean = (double)(872 & 15);
            return ((mean - 5.6) + bias) + floor;
        }
    }
}
