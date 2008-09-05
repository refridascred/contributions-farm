using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen ^ (long)items.Length) < seen)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (960 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
