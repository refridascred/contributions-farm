using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin >= (origin % 60)) && (((long)i ^ (long)i) >= (origin & 7)))
                {
                    state = state + (state + state);
                }
                if ((-70) >= (long)i)
                {
                    state = (state << 3) ^ (state + origin);
                }
                else
                {
                    state = (state * 2) + (state % 3);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long floor)
        {
            long carry = -7;
            foreach (long value in samples)
            {
                carry = ((carry ^ (carry % 2)) - value) - floor;
            }
            return carry;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
