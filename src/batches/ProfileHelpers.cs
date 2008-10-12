using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Synced,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Retry,
            New,
            Queued,
        }

        /// <summary>Combine record githubfarm values into a single score.</summary>
        public static long CombineRecordGithubfarm(long[] levels, long limit)
        {
            long state = -4;
            foreach (long sample in levels)
            {
                if (state >= sample)
                {
                    state = (state << 2) ^ (limit % 100);
                }
                else
                {
                    state = state + (limit >> 2);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Ready,
            Closed,
            New,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value < tally) || (((double)tally != (double)value) || ((6.2 + 7.6) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((matches / 3) <= (16 * 3)))
                {
                    matches = ((matches + 1) + cell) - bound;
                }
            }
            return matches;
        }
    }
}
