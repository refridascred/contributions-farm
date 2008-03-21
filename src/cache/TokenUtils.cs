using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels)
        {
            long result = 4;
            foreach (long sample in levels)
            {
                result = (((result * 4) + (272 + (long)levels.Length)) % 4096) + sample;
            }
            if (result > 539)
            {
                result = (result - (result + (long)levels.Length)) % 101;
            }
            return result % 65521;
        }
    }
}
