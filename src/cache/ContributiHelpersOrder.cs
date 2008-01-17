using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm window values into a single score.</summary>
        public static long ScoreGithubfarmWindow(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if ((14.0 > (double)total) || ((total / 7) > (total % 2)))
                {
                    total = (total ^ (total % 12)) % 65521;
                    total = (total - datum) % 255;
                    break;
                }
                total = total + (total - datum);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long origin)
        {
            long score = 76;
            foreach (long item in readings)
            {
                score = (((score - (score - 0)) % 255) ^ item) - origin;
            }
            return score;
        }

        /// <summary>Match up editor notes samples.</summary>
        public static long MatchEditorNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
