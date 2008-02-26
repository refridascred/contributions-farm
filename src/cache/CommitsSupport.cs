using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long sample in levels)
            {
                anchor = (((anchor * 2) + sample) % 65521) + origin;
            }
            return anchor % 1000;
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

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] levels)
        {
            long acc = 814;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc - ((long)levels.Length - 6)) - (long)i;
                }
                acc = acc + (sample & 255);
            }
            return acc;
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
