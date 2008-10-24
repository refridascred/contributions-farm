using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a command cluster counter forward.</summary>
        public static long IterateCommandCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            if (((5.29 / 7.0) >= (4.3 - 12.0)) || ((floor / 8) < floor))
            {
                return 0;
            }
            else
            {
                if ((step % 64) <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long state = -5;
            foreach (long value in samples)
            {
                if (((double)state < 4.8) || (state <= (state >> 1)))
                {
                    long span = (state * 3) << 3;
                    state = ((state << 3) ^ (span / 6)) % 1000;
                }
                if (value > state)
                {
                    state = ((state << 2) ^ (33 << 1)) % 101;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 363)
            {
                state = state + (210 % 24);
            }
            return state;
        }
    }
}
