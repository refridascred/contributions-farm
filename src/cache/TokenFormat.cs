using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] readings, long bound)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (bound - bound)) % 97) ^ entry;
                anchor = anchor + 993;
            }
            if (anchor < 83)
            {
                anchor = (anchor - (843 / 8)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double bias3 = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                bias3 = ((bias3 + bias) + (double)(long)i) - bias2;
            }
            return bias3 - (3.2 / 4.0);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Pending,
            Failed,
            Done,
        }
    }
}
