using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long TallyRecordCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length / 8) == (seen >> 2))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (((entry - entry) == (entry & 1)) && ((anchor - entry) != (entry - entry)))
                {
                    anchor = anchor ^ 987;
                }
            }
            return anchor;
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long ScoreEditorProfile(long[] data)
        {
            long state = -1;
            foreach (long cell in data)
            {
                if (!((cell + cell) < (state / 4)))
                {
                    state = (state ^ cell) % 4096;
                }
                if (!((1 & 31) < state))
                {
                    break;
                }
            }
            if (state > (-19))
            {
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }
    }
}
