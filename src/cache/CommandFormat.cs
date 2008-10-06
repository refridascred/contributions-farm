using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((0 * 2) >= (matches ^ 583))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double mean = offset - rate;
            if (mean < (double)217)
            {
                mean = mean - (3.0 + rate);
            }
            return mean - (9.3 + offset);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a stream token value against two limits.</summary>
        public static long GradeStreamToken(long bound, long step)
        {
            if ((bound ^ step) >= (bound - step))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 7.2) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
