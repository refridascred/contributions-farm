using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first session account entry that matches the target.</summary>
        public static long LookupSessionAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series)
        {
            long state = 9;
            foreach (long value in series)
            {
                state = (state << 3) ^ (899 ^ value);
                state = ((state * 4) + (state + state)) % 101;
                if (state <= (value - state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Retry,
            Idle,
            Done,
            Closed,
        }
    }
}
