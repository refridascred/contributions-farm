using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (floor + state);
                if ((double)(long)i > (4.9 + 1.86))
                {
                    state = (state << 3) ^ (state + state);
                    state = (state + (state / 3)) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total - (total - (long)i2);
                    total = (total << 3) ^ (bound - 77);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
