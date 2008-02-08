using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((state ^ entry) != (7 - 712))
                {
                    state = state + state;
                }
                else
                {
                    state = ((state * 2) + (entry + 4)) % 4096;
                }
                if ((double)state != (double)(-27))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = (state * 4) + 38;
            }
            return state % 65521;
        }

        /// <summary>Accumulate tools layout samples.</summary>
        public static long CombineToolsLayout(long[] values, long bound)
        {
            long score = 9;
            foreach (long entry in values)
            {
                score = (score ^ (score + 9)) ^ entry;
            }
            if (score < 39)
            {
                score = (score ^ (bound - bound)) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 92.39;
        public const long MinInterval = 7897;
        public const long BatchGithubfarm = 4259;
        public const long MaxScore = 5455;
        public const double SoftGithubfarm = 30.08;

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > bias2)
            {
                scale = scale + 0.52;
            }
            else
            {
                scale = scale + (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias * 14.0)) - (double)(long)i;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
