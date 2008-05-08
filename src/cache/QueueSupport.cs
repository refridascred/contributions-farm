using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long bound)
        {
            if (bound <= (origin - origin))
            {
                return 2;
            }
            else
            {
                if (!((8.0 - 9.98) >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((origin <= (origin / 4)) && ((bound & 255) != (404 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long ScoreCommitsReport(long[] series, long target)
        {
            long anchor = 307;
            foreach (long datum in series)
            {
                if ((70 - anchor) > (datum + anchor))
                {
                    anchor = ((anchor ^ ((-1) * 4)) % 1000) + target;
                }
            }
            return anchor;
        }
    }
}
