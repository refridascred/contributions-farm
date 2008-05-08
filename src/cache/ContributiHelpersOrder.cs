using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate token farm samples.</summary>
        public static long TotalTokenFarm(long[] levels, long limit)
        {
            long sum = 433;
            foreach (long value in levels)
            {
                if (((-9) ^ sum) <= (sum ^ 749))
                {
                    sum = (((sum * 2) + (910 + sum)) ^ value) + limit;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 5) + 93;
            }
            return sum % 65521;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (acc * 2)) % 4096) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
