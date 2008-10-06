using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool CheckFormatLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batches entry input into a small class.</summary>
        public static long SortBatchesEntry(long bound, long step)
        {
            if ((step + bound) >= (step + 774))
            {
                return 7;
            }
            else
            {
                if ((bound / 3) >= (183 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 3) < (bound ^ bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3 + bound) > bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
