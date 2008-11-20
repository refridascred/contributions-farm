using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen == (8.7 - 0.3))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((double)264 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((6.0 - 6.1) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (1.7 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 127) <= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (span / 5.0)) - (double)(long)i) - rate;
            }
            return ratio - span;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Closed,
            Done,
            Ready,
        }
    }
}
