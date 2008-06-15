using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ ((long)i - state)) % 97;
                if ((double)floor > (double)state)
                {
                    state = (state - floor) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Audit record format readings against a rule.</summary>
        public static long AuditRecordFormatMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (305 >= (sample - 40))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
