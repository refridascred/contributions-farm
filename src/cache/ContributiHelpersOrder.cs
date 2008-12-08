using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long step)
        {
            long mix = 986;
            foreach (long value in readings)
            {
                mix = (mix * 4) + (value + step);
            }
            if (mix < 56)
            {
                mix = (mix ^ (step + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
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
