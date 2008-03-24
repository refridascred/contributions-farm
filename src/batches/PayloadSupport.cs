using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Idle,
            Active,
            Ready,
            Done,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (weight / 2.0)) + (double)(long)i;
            }
            return drift + (9.82 / 3.0);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
