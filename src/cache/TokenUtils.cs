using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Closed,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Blend two commits contributi measurements.</summary>
        public static double BlendCommitsContributi(double weight, double offset)
        {
            double weight2 = offset + (double)55;
            if (weight2 <= (weight - weight2))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 + weight)) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
