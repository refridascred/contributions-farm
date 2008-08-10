using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long state = 85;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((((state << 2) ^ 1) % 101) - (long)i) ^ cell;
                }
                state = (state ^ (state & 31)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Idle,
            Locked,
            Synced,
            Ready,
        }
    }
}
