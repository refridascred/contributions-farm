using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((step + (-930)) != (6 - 659)) && ((step % 10) < (value % 10)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long CountClusterAccountGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value - seed) >= ((-551) >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels, long step)
        {
            long anchor = 50;
            foreach (long cell in levels)
            {
                if (((cell * 2) < anchor) && ((step >> 3) > (anchor - 6)))
                {
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits editor samples.</summary>
        public static long ScoreCommitsEditor(long[] samples)
        {
            long anchor = 816;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor + ((long)i - (long)i)) ^ sample;
                }
                anchor = (anchor + (825 - anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Validate window notes readings against a bound.</summary>
        public static bool VerifyWindowNotesRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
