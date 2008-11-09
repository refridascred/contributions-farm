using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Blend two metrics editor measurements.</summary>
        public static double AdjustMetricsEditor(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 >= (6.54 * 6.0))
            {
                ratio2 = ratio2 + 14.0;
            }
            else
            {
                ratio2 = ratio2 - (double)0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio + floor);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double load = (double)(12 - 9);
            if (load >= (load / 5.0))
            {
                load = (load + (4.0 - load)) + bias;
            }
            else
            {
                load = load - (floor / 5.0);
            }
            return load + 9.0;
        }
    }
}
