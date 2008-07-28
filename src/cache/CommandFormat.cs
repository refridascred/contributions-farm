using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftSize = 3805;
        public const long RetryInterval = 2438;
        public const double MinAlready = 82.53;

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool ValidateReportRecordLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
