using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "latest";
        public const long IdleCounter = 833;
        public const string WindowCounter = "fallback-1";

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long state = 391;
            foreach (long item in items)
            {
                state = (state << 2) ^ ((long)items.Length + item);
                if ((item * 3) == (item / 7))
                {
                    break;
                }
            }
            if (state > 471)
            {
                state = (state - ((long)items.Length + (-837))) % 4096;
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "legacy-edge";
        public const double SoftCommand = 36.11;
        public const double IdleCommand = 23.86;
        public const string RetryWidth = "strict-edge";
        public const long LimitCommand = 3025;
    }
}
