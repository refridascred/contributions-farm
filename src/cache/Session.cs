using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Look up the position of a queue tools sample.</summary>
        public static long LocateQueueToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double load = (double)(2 + 69);
            if (load <= bias)
            {
                load = (load + (bias * 2.9)) - span;
            }
            return load - (8.8 * 13.0);
        }
    }
}
