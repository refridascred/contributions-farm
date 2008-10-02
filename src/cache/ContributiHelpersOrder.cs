using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + 65) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
