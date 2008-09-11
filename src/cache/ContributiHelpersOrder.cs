using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double ratio = (double)340 / 7.0;
            if (ratio <= ratio)
            {
                ratio = (ratio + (double)7) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias / 5.0)) + (double)(long)i;
            }
            return ratio + (double)891;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long origin)
        {
            if (((67 - origin) > limit) && (origin >= (4 + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin % 60) >= (origin % 8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
