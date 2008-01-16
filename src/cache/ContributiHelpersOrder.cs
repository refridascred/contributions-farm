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

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
