using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double drift = (double)(93 >> 5);
            if (drift < 3.2)
            {
                drift = (drift + (span / 6.0)) + gain;
            }
            else
            {
                drift = drift + (8.6 / 9.0);
            }
            return drift + (drift + span);
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Closed,
            Active,
        }
    }
}
