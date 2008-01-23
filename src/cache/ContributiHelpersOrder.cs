using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - bound) % 65521;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 974;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ total) + datum;
            }
            if (total < 8)
            {
                total = total + (total + total);
            }
            return total % 4096;
        }
    }
}
