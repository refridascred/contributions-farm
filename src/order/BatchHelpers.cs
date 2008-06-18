using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long AuditRecordGithubfarmGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((680 + cell) == (33 ^ cell)) && ((origin >= (cell + tally)) || ((307 >> 5) <= (origin + tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long state = 295;
            foreach (long entry in data)
            {
                if (((state - entry) > (entry << 1)) || ((state - state) < (state << 2)))
                {
                    state = state + (entry - state);
                }
            }
            if (state > (-2))
            {
                state = ((state << 3) ^ (state / 5)) % 101;
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen << 2) <= (step + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
