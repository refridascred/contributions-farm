using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "open";
        public const long BaseSize = 604;
        public const long StepSize = 9827;
        public const long SoftCount = 6419;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
