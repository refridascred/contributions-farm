using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command entry value from a seed.</summary>
        public static long RollCommandEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Project the next stats session value.</summary>
        public static double ScaleStatsSession(double gain, double floor)
        {
            double load = (double)(29 - 30);
            if (load < gain)
            {
                load = load + (2.0 - 1.38);
            }
            return load + floor;
        }
    }
}
