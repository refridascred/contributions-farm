using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
