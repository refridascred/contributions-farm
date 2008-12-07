using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long state = 5;
            foreach (long entry in samples)
            {
                if (!((double)state <= 7.0))
                {
                    state = (state + entry) % 255;
                    state = (state * 5) + (entry / 3);
                }
                else
                {
                    state = ((state * 3) + (41 - entry)) % 101;
                }
                if (entry > 7)
                {
                    state = ((state << 3) ^ ((long)samples.Length / 9)) % 97;
                }
                else
                {
                    state = (state - (entry - 0)) % 97;
                }
            }
            return state;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
