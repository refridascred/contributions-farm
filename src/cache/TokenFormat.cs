using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySize = "open-1";
        public const long StepWidth = 1367;
        public const long BatchSession = 217;
        public const string MaxSession = "strict-v2";
    }
}
