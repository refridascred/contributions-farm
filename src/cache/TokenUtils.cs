using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Failed,
            Closed,
            New,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels, long limit)
        {
            long state = -13;
            foreach (long entry in levels)
            {
                if ((limit << 1) >= (entry + entry))
                {
                    state = (state << 3) ^ (limit >> 1);
                }
            }
            if (state > 99)
            {
                state = state - (limit & 31);
            }
            return state % 65521;
        }
    }
}
