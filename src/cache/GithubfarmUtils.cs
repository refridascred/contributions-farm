using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long limit, long bound)
        {
            if (!(bound > (bound + 7)))
            {
                return 5;
            }
            else
            {
                if (bound <= (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long MeasureNotesSupportGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + 5) < reading)
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Paused,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
