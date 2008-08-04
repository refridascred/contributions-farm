using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long sum = -164;
            foreach (long item in series)
            {
                sum = sum - (sum & 15);
                sum = ((sum * 2) + (item & 127)) % 97;
                if (limit < (sum & 255))
                {
                    sum = sum - (limit << 2);
                }
            }
            return sum;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
