using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "standard-1";
        public const long MaxFactor = 5127;
        public const double MinFilter = 18.15;
        public const long StepLevel = 3712;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Look up the position of a command report sample.</summary>
        public static long SeekCommandReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
