using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxInterval = 685;
        public const long StepInterval = 8755;
        public const double BaseOrder = 16.06;
        public const string SoftFactor = "strict-edge";
        public const string MaxTimeout = "standard-1";

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Active,
            Retry,
            New,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
