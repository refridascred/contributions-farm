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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
