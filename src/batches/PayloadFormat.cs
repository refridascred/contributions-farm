using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count queue token pairs that satisfy a relation.</summary>
        public static long MatchQueueTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
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
            Ready,
            Done,
            New,
            Queued,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "open-edge";
        public const string DefaultRecord = "open-1";
        public const long DefaultCount = 6614;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((origin + count) >= (count * 4))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
