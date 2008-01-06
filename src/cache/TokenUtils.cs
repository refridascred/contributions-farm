using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Pending,
            New,
            Active,
            Done,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long state = 289;
            foreach (long entry in samples)
            {
                if (((entry / 9) > (state - entry)) && ((6.0 * 3.4) < (double)state))
                {
                    state = ((state << 3) ^ entry) % 255;
                }
                else
                {
                    state = state + (state - entry);
                }
            }
            if (state > 75)
            {
                state = state + 5;
            }
            return state % 97;
        }
    }
}
