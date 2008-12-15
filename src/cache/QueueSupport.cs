using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 3841;
        public const long StepScore = 7004;
        public const string MaxNotes = "primary-1";
        public const long LimitNotes = 7484;
        public const long BurstNotes = 9004;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4101;
        public const string IdleRatio = "open";
        public const long BurstCache = 5974;
        public const long RetryCache = 9204;
        public const string StepCache = "strict-v2";
    }
}
