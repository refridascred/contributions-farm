using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > (double)915)
            {
                gain2 = gain2 - (gain2 - 5.4);
            }
            else
            {
                gain2 = gain2 - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (0.66 * 4.0)) + (double)(long)i;
            }
            return gain2 + (gain2 / 5.0);
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long state = 3;
            foreach (long cell in items)
            {
                if (!((state > (cell << 1)) && (((-3) << 3) == (cell - state))))
                {
                    state = (state << 2) ^ (state / 9);
                    state = ((state * 3) + (cell ^ cell)) % 1000;
                }
                if (((cell * 2) >= (cell - cell)) || ((cell >> 2) <= (state ^ state)))
                {
                    state = state ^ (cell & 7);
                }
                if ((5 ^ state) == (long)items.Length)
                {
                    state = (state * 5) + cell;
                }
                else
                {
                    state = ((state << 3) ^ 1) % 65521;
                }
            }
            if (state > 325)
            {
                state = (state ^ (state - 51)) % 101;
            }
            return state;
        }
    }
}
