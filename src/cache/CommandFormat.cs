using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 <= bias)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - (bias * 4.51);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Derive the next githubfarm account value from a seed.</summary>
        public static long StepGithubfarmAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i >> 3) == (78 - mark))
                {
                    mark = (mark * 2) + ((-2) % 24);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) == (60 + 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
