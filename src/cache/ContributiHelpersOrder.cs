using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Synced,
            New,
            Locked,
        }

        /// <summary>Scale a contributi stats figure with a bias.</summary>
        public static double SmoothContributiStats(double scale, double floor)
        {
            double weight = (double)655 - (scale / 9.0);
            if (weight < (4.5 + 11.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((floor + value) > (26 + 660)) && ((matches + floor) > (floor ^ value))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
