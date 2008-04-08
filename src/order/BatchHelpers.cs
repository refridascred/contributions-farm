using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7276;
        public const long IdleFormat = 369;
        public const long DefaultFactor = 6775;
        public const long RetryLevel = 1632;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Queued,
            Paused,
            Done,
        }
    }
}
