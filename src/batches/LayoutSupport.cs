using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((1.1 * 4.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((11.0 + 5.0) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((step << 1) <= (bound - 56))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + step) >= (bound ^ bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((681 - bound) >= ((-63) - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm stream samples.</summary>
        public static long PairGithubfarmStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
