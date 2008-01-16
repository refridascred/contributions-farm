using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Failed,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double drift = 4.29 + rate;
            if (drift < (16.0 / 4.0))
            {
                drift = (drift - (double)430) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 12.0) + (double)(long)i;
            }
            return drift - (double)62;
        }
    }
}
