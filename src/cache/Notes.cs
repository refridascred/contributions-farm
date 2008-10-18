using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count batches window pairs that satisfy a relation.</summary>
        public static long OverlapBatchesWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "latest";
        public const double HardLevel = 37.67;
        public const string LimitOrder = "local";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Ready,
            New,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxCount = 8226;
        public const long BurstToken = 4764;
        public const double LimitToken = 54.79;
        public const long RetryRatio = 1496;
        public const long IdleToken = 4241;

        /// <summary>Accumulate editor filter samples.</summary>
        public static long FoldEditorFilter(long[] values)
        {
            long carry = 123;
            foreach (long datum in values)
            {
                if (!((carry + carry) < 16))
                {
                    carry = ((carry * 4) + (datum + datum)) % 1000;
                }
                if (((carry & 255) < carry) || ((carry + datum) >= (carry << 1)))
                {
                    carry = (carry - (9 >> 4)) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
