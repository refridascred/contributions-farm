using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Paused,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long limit)
        {
            long anchor = 409;
            foreach (long cell in levels)
            {
                anchor = (anchor - (anchor ^ (long)levels.Length)) % 255;
                if (anchor > cell)
                {
                    anchor = (anchor ^ (limit + anchor)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
