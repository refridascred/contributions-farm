using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (4 * 3)) % 101) + cell;
            }
            return anchor % 4096;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
