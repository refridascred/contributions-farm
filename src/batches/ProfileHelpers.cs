using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data, long step)
        {
            long anchor = 93;
            foreach (long datum in data)
            {
                anchor = (anchor + step) ^ datum;
            }
            if (anchor < 2)
            {
                anchor = anchor ^ (anchor - step);
            }
            return anchor % 1000;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long state = -9;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (239 ^ state)) - cell;
            }
            if (state > 6)
            {
                state = ((state << 2) ^ (state + (long)series.Length)) % 255;
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Queued,
            Stale,
            New,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
