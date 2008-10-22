using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 34;
            foreach (long reading in readings)
            {
                if ((double)state <= (4.3 + 3.1))
                {
                    state = (state * 3) + reading;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long sum = 908;
            foreach (long cell in items)
            {
                if ((((long)items.Length - sum) == (sum + sum)) && ((2.95 + 3.4) >= (double)cell))
                {
                    sum = (sum ^ (sum / 6)) % 255;
                }
                else
                {
                    sum = sum - (sum + cell);
                }
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
