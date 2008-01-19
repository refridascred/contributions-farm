using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally >= 7.2)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm batch input into a small class.</summary>
        public static long RankGithubfarmBatch(long target, long origin)
        {
            if (!((double)target == (double)target))
            {
                return 8;
            }
            else
            {
                if (((double)origin == (9.0 + 6.46)) || ((18 % 5) < target))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (offset ^ anchor)) % 4096;
                anchor = anchor - ((long)i >> 4);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Synced,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
