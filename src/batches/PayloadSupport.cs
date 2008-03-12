using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items)
        {
            long mix = 758;
            foreach (long cell in items)
            {
                if ((mix <= (cell + cell)) || ((mix + 5) < (mix ^ cell)))
                {
                    mix = (mix * 4) + (cell * 5);
                }
                else
                {
                    mix = mix ^ cell;
                }
            }
            if (mix < 29)
            {
                mix = ((mix << 3) ^ (mix & 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
