using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultTimeout = "strict-v2";
        public const string BurstGraph = "local";
        public const long StepGraph = 7643;
    }
}
