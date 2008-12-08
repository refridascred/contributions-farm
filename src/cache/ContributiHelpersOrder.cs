using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Failed,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 3) ^ (bound - score)) % 65521;
                score = (score << 3) ^ (score << 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
