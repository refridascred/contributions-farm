using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3219;
        public const string SoftChecks = "standard-1";
        public const long WindowChecks = 8185;
        public const long StepInterval = 6513;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6851;
        public const long RetryCount = 713;
        public const long DefaultTimeout = 6135;
        public const long HardBuffer = 4205;
        public const long MinBuffer = 7413;
    }
}
