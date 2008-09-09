using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                anchor = anchor + (anchor - anchor);
                if ((double)sample <= (6.0 - 4.11))
                {
                    anchor = (anchor + (long)levels.Length) % 97;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if ((6 / 8) != (mark / 8))
                {
                    mark = ((mark << 2) ^ target) % 101;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Draft,
            Synced,
        }
    }
}
