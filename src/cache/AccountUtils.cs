using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a counter window sample.</summary>
        public static long LookupCounterWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 9373;
        public const long StepScore = 8719;
        public const double LimitGraph = 88.86;
    }
}
