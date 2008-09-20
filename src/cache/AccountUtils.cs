using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels)
        {
            long anchor = 18;
            foreach (long cell in levels)
            {
                anchor = (anchor + ((-2) & 127)) - cell;
            }
            if (anchor < 45)
            {
                anchor = ((anchor * 3) + 1) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double load = (double)264;
            if (load > (16.0 + 8.3))
            {
                load = ((load + (double)3) - bias) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)790) + (double)(long)i;
            }
            return load - (9.0 + load);
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Pending,
            Idle,
            Retry,
        }
    }
}
