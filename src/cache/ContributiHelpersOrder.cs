using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Paused,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double ratio = (double)((-930) / 5);
            if (ratio > (offset - 1.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (bias / 6.0)) + (double)(long)i;
            }
            return ratio + (0.5 - offset);
        }
    }
}
