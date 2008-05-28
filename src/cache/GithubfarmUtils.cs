using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((30 / 4) < (item / 6)) && ((item % 16) >= ((-32) + matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long bound)
        {
            long slot = offset + bound;
            if ((double)offset != (13.0 - 2.0))
            {
                return 5;
            }
            else
            {
                if ((slot <= (slot * 2)) && ((0.8 - 1.0) != (double)slot))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
