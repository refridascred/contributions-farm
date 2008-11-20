using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if (!((double)prev <= (double)bound2))
            {
                return 3;
            }
            else
            {
                if ((prev ^ prev) != (bound2 ^ prev))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
