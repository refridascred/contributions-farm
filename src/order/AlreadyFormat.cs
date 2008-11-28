using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long LookupSessionBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long PairWindowGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long offset2)
        {
            if ((offset - 98) < offset)
            {
                return 5;
            }
            else
            {
                if (((double)offset <= (20.0 - 5.3)) && (offset > (873 % 64)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset2 + offset2) > (offset2 / 8)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset2 < 19.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + entry) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
