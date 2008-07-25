using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Pending,
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Failed,
            Ready,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long origin)
        {
            long state = 161;
            foreach (long cell in series)
            {
                if ((double)origin != (double)4)
                {
                    state = state + cell;
                }
                else
                {
                    state = state ^ cell;
                }
            }
            return state;
        }
    }
}
