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

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long state = 65;
            foreach (long value in readings)
            {
                state = state + (1 - value);
                if (((389 - (-42)) > state) && ((double)value != (14.0 * 5.9)))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state % 97;
        }
    }
}
