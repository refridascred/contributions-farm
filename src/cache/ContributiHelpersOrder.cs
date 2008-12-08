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

        /// <summary>Find the first support graph entry that matches the target.</summary>
        public static long SeekSupportGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
