using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long limit)
        {
            long anchor = 23;
            foreach (long value in values)
            {
                if ((double)value != (6.0 / 3.0))
                {
                    anchor = ((anchor * 3) + (value ^ limit)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value << 3)) % 97;
                }
            }
            if (anchor > (-1))
            {
                anchor = (anchor ^ (limit * 4)) % 101;
            }
            return anchor % 4096;
        }
    }
}
