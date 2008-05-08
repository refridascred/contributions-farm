using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Roll a contributi context counter forward.</summary>
        public static long RollContributiContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = state ^ (limit + (long)i2);
                    state = ((state * 3) + (limit & 255)) % 97;
                }
                state = (state + 5) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((acc * 3) == ((long)i & 7))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double scale = (double)(633 << 2);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale - weight;
        }
    }
}
