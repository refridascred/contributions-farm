using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            New,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = mix ^ mix;
                mix = (mix + mix) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
