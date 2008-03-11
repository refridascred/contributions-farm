using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long floor)
        {
            if ((9 << 1) >= (floor - origin))
            {
                return 8;
            }
            else
            {
                if ((double)origin > 2.1)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
